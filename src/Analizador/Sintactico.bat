SET JAVA_HOME="C:\Program Files\Java\jdk1.7.0_21\bin"
SET PATH=%JAVA_HOME%;%PATH% 
SET CLASSPATH=%JAVA_HOME%; 
cd C:\Users\CINOTER\Documents\USAC\SEGUNDO SEMESTRE 2014\COMPI2\LABORATORIO\[Compi2]Prac1_2s14_200915455\src\Analizador
java -classpath C:\Fuentes\ java_cup.Main -parser Parser -symbols simbolos Parser.txt
pause