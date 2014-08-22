using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Parsing;

namespace _Compi2_Prac1_2s14_200915455
{
    public partial class Form1 : Form
    {
        delegate void SetTextCallback(string text);

        //VARIABLES PARA EL SOCKET
        Thread hilo = null;
        TcpListener receptor;
        TcpClient cliente;


        //LISTA DE PALABRAS
        public static List<string> ListaPalabras = new List<string>();
        //LISTA DE PALABRAS
        public static List<int> ListaNumeros = new List<int>();
        //TOTAL DE NUMEROS EN CADENA
        public static int Total_Num = 0;
        //TOTAL DE PALABRAS EN CADENA
        public static int Total_Palab = 0;
        //NUMEROS ORDENADOS ASCENDENTEMENTE
        String NumAsc = "";
        //NUMEROS OREDDENADOS DESCENDENTEMENTE
        String NumDes = "";
        //PALABRAS ORDENADAS ASCENDENTEMENTE
        String PalAsc = "";
        //PALABRAS ORDENADAS DESCENDENTEMENTE
        String PalDes = "";
        //lista de numeros separados por coma
        String numeros = "";
        //lista de palabras separadas por coma
        String palabras = "";
        //lista de numeros repetidos
        String NumerosRepetidos = "";
        //lista de palabras repetidas
        String PalabrasRepetidas = "";

        int cn = 0;
        
       
        public Form1()
        {
            InitializeComponent();

            //monitorer cualquier ip por el puerto 1318
            receptor = new TcpListener(IPAddress.Any, 1318);
            //se inicia el monitoreo
            receptor.Start();
            //hilo para recibir clientes 
            hilo = new Thread(Monitorear);
            hilo.Start();
        }

        // hilo para monitorear cadenas de entrada
        public void Monitorear()
        {
          
            cliente = receptor.AcceptTcpClient();

            TcpClient cliente2 = (TcpClient)cliente;
            NetworkStream clienteStream = cliente2.GetStream();
            byte[] mensaje = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    //si un cliente envia un mensaje
                    bytesRead = clienteStream.Read(mensaje, 0, 4096);
                    this.SetText(Encoding.ASCII.GetString(mensaje, 0, bytesRead));
                }
                catch//si se presenta un error
                {
                    
                    break;
                }

                if (bytesRead == 0)//si no se pude leer el mensaje
                {
                    
                    break;
                }

            }

            //se cierra la conexion.
            cliente2.Close();
        }


        //muestra el texto en segundo plano con un hilo
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.

            if (this.rtbEntrada.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                rtbEntrada.Text = "";
                this.rtbEntrada.Text = this.rtbEntrada.Text + text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtbEntrada.Text != null)
            {
                //REINICIAR TODO
                rtbSalida.Text = "";
                //LISTA DE PALABRAS
         ListaPalabras.Clear();
         ListaNumeros.Clear();
        Total_Num = 0;
        Total_Palab = 0;
        NumAsc = "";
        NumDes = "";
        PalAsc = "";
        PalDes = "";
        numeros = "";
        palabras = "";
        NumerosRepetidos = "";
       PalabrasRepetidas = "";
        cn = 0;

               
                //rtbSalida.Text = texto;
                try
                {
                                    //analizar cadena
                Analizador a = new Analizador(new Sintactic());
                string str = a.parse(rtbEntrada.Text, new AccionesCalcu()).ToString();
                //string str = a.parse(texto, new AccionesCalcu()).ToString();
                //MessageBox.Show(str);
                //MessageBox.Show(ListaPalabras[0]);

                ///////graficar /////////////////
                cn = 0;
               Console.WriteLine(this.CodigoDot(this.getRoot(rtbEntrada.Text, new Sintactic())));
              StringBuilder arDot = new StringBuilder();
              arDot.Append("digraph G {"+Environment.NewLine);
              arDot.Append(this.CodigoDot(this.getRoot(rtbEntrada.Text, new Sintactic())));
              arDot.Append("}");
                this.crearArchivo(arDot.ToString(), "arbol.txt");
                this.GenerarGrafica("C:\\COMPI2_Practica1\\arbol.txt", "C:\\COMPI2_Practica1\\");
                Console.ReadLine();



                this.EncontrarRepetidos();

                foreach(int n in ListaNumeros)
                   numeros = numeros + n+ "," ;

                foreach (String l in ListaPalabras)
                    palabras = palabras + l + "<br>" + System.Environment.NewLine;
                
                //se elimina texto de mas de mas
                if(numeros!="")
                numeros = numeros.Substring(0, numeros.Length - 1);
               // letras = letras.Substring(0, letras.Length - 1);
               



                //////////////////// OERDENAR LISTAS ///////////////////////////////////
                //----------------------------------------------------------------------------
                ListaNumeros.Sort();
                ListaNumeros=ListaNumeros.Distinct().ToList();
                foreach (int n in ListaNumeros)
                    NumAsc = NumAsc + n + ",";
                if(NumAsc!="")
                NumAsc = NumAsc.Substring(0, NumAsc.Length - 1);
                //------------------------------------------------------------------------------
                ListaPalabras.Sort();
                ListaPalabras = ListaPalabras.Distinct().ToList();
                foreach (String l in ListaPalabras)
                    PalAsc = PalAsc + l + "<br>" + System.Environment.NewLine;



                ///////////////// OERDEN INVERSO DE LISTAS //////////////////////////////////
                //----------------------------------------------------------------------------
                ListaNumeros.Reverse();
                foreach (int n in ListaNumeros)
                    NumDes = NumDes + n + ",";
                if(NumDes!="")
                NumDes = NumDes.Substring(0, NumDes.Length - 1);
                //----------------------------------------------------------------------------
                ListaPalabras.Reverse();
                foreach (String l in ListaPalabras)
                    PalDes = PalDes + l + "<br>" + System.Environment.NewLine;

                

                //rtbSalida.AppendText(numeros);
                //rtbSalida.AppendText(letras);
                this.CrearCodigoHtml();
                tabControl1.SelectedIndex = 1;
                }catch(Exception ex)
                {
                    MessageBox.Show("ERROR AL ANLIZAR LA ENTRADA");
                    Console.WriteLine(ex);

                }


                

                
               
            }
        }
    
    
        private void CrearCodigoHtml()
        {
            String codigoHtml = "<html>" + System.Environment.NewLine +
                                "<h1>Total de numeros: " + Total_Num + "</h1>" + System.Environment.NewLine +
                                "<p>numeros repetidos: " + System.Environment.NewLine +
                                "<table border=1> " + System.Environment.NewLine +
                                "<tr> " + System.Environment.NewLine +
                                "<td>numero</td> " + System.Environment.NewLine +
                                "<td>cantidad</td> " + System.Environment.NewLine +
                                "</tr> " + System.Environment.NewLine +
                               NumerosRepetidos+
                                "</table> " + System.Environment.NewLine +
                                "<br>Listado ordenado ascendente " + System.Environment.NewLine +
                                " <br>" + NumAsc + System.Environment.NewLine +
                                "<br> " + System.Environment.NewLine +
                                "<br>Listado ordenado descendente " + System.Environment.NewLine +
                                "<br>" + NumDes + System.Environment.NewLine +
                               "</p>" + System.Environment.NewLine +
                               "<h1>Total palabras: " + Total_Palab + "</h1> " + System.Environment.NewLine +
                               "<p>palabras repetidas: " + System.Environment.NewLine +
                               "<table border=1> " + System.Environment.NewLine +
                               "<tr>" + System.Environment.NewLine +
                               "<td>palabra</td>" + System.Environment.NewLine +
                               "<td>cantidad</td> " + System.Environment.NewLine +
                               "</tr>" + System.Environment.NewLine +
                               "<tr> " + System.Environment.NewLine +
                               PalabrasRepetidas+
                               "</tr>" + System.Environment.NewLine +
                               " </table>" + System.Environment.NewLine +
                               "<br>" + System.Environment.NewLine +
                               "<table border=1> " + System.Environment.NewLine +
                               "<tr>" + System.Environment.NewLine +
                               "<td>Palabras en orden ascendente</td>" + System.Environment.NewLine +
                               "<td>Palabras en orden descendente</td>" + System.Environment.NewLine +
                               " </tr> " + System.Environment.NewLine +
                               " <tr> " + System.Environment.NewLine +
                               "<td>" + System.Environment.NewLine +
                               PalAsc + System.Environment.NewLine +
                               "</td> " + System.Environment.NewLine +
                               "<td>" + System.Environment.NewLine +
                               PalDes + System.Environment.NewLine +
                               "</td>" + System.Environment.NewLine +
                               "</tr> " + System.Environment.NewLine +
                               "</table>" + System.Environment.NewLine +
                               "</p>" + System.Environment.NewLine +
                               "<h1>Arbol de derivacion</h1> " + System.Environment.NewLine +
                               "<img src=\"C:\\COMPI2_Practica1\\arbol.jpg\"> " + System.Environment.NewLine +
                               "</html>";


            rtbSalida.Text = "";
            rtbSalida.Text = codigoHtml;
            this.crearArchivo(codigoHtml,"salida.html");
            webBrowser1.Navigate("C:\\COMPI2_Practica1\\salida.html");
        }
    

        private void crearArchivo(String codigo,String nombre)
        {
            // crear el path
            var archivo = "C:\\COMPI2_Practica1\\"+nombre;

            // eliminar el fichero si ya existe
            if (File.Exists(archivo))
                File.Delete(archivo);

            // crear el fichero
            using (var fileStream = File.Create(archivo))
            {
                var texto = new UTF8Encoding(true).GetBytes(codigo);
                fileStream.Write(texto, 0, texto.Length);
                fileStream.Flush();
            }
        }

        
        public void EncontrarRepetidos()
        {
           /// ENCONTRAR NUMEROS REPETIDOS
            var query = from item in ListaNumeros
                        let extension = item
                        group item by extension into g
                        select new { Key = g.Key, Values = g };

            foreach (var item in query)
            {
                 if(item.Values.Count()>1)
                NumerosRepetidos = NumerosRepetidos + "<tr>" + "<td>" + item.Key + "</td>"  + "<td>" + item.Values.Count() + "</td></tr>"+System.Environment.NewLine;
               
            }

            var query2 = from item in ListaPalabras
                        let extension = item
                        group item by extension into g
                        select new { Key = g.Key, Values = g };

            foreach (var item in query2)
            {
                if (item.Values.Count() > 1)
                    PalabrasRepetidas = PalabrasRepetidas + "<tr>" + "<td>" + item.Key + "</td>"  + "<td>" + item.Values.Count() + "</td></tr>" + System.Environment.NewLine;

            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.EncontrarRepetidos();
        }


        //////////////////////////////////////////////////////////////////////////////////
        //////////////////////// METODOS PARA DIBUJAR EL ARBOL //////////////////////////
        //////////////////////////////////////////////////////////////////////////////////
        public ParseTreeNode getRoot(string sourceCode, Grammar grammar)
        {

            LanguageData language = new LanguageData(grammar);

            Parser parser = new Parser(language);

            ParseTree parseTree = parser.Parse(sourceCode);

            ParseTreeNode root = parseTree.Root;

            return root;

        }

        public String CodigoDot(ParseTreeNode node)
        {
           
            StringBuilder b = new StringBuilder();
            String label = node.ToString();
            if (label.Contains("(Key symbol)"))
                label = label.Substring(0, label.Length - 13);
            b.Append("node" + cn + " [label=\"" + label+ "\"];" + Environment.NewLine);
            int c = cn;
            cn = cn + 1;
            
            foreach (ParseTreeNode child in node.ChildNodes)
            {
                
               
                b.AppendFormat("{0}->{1}{2}", "\"" + "node"+ c + "\"", "\"" + "node"+ (cn)  + "\";", Environment.NewLine);
                b.Append(CodigoDot(child));
                
               
            }

            return b.ToString();
        }


        private  void GenerarGrafica(string fileName, string path)
        {
            try
            {
                var command = string.Format("dot -Tjpg {0} -o {1}", Path.Combine(path, fileName), Path.Combine(path, fileName.Replace(".txt", ".jpg")));

                var procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + command);

                var proc = new System.Diagnostics.Process();

                proc.StartInfo = procStartInfo;

                proc.Start();

                proc.WaitForExit();

            }
            catch (Exception x)
            {

            }
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            
            cliente = receptor.AcceptTcpClient();

           
            
        }
    }
}
