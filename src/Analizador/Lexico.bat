SET JAVA_HOME="C:\Program Files\Java\jdk1.7.0_21\bin"
SET PATH=%JAVA_HOME%;%PATH% 
SET CLASSPATH=%JAVA_HOME%; 
SET JFLEX_HOME= C:\Fuentes\jflex-1.5.1
cd C:\Users\CINOTER\Documents\USAC\SEGUNDO SEMESTRE 2014\COMPI2\LABORATORIO\[Compi2]Prac1_2s14_200915455\src\Analizador
java -jar %JFLEX_HOME%\lib\jflex-1.5.1.jar Scanner.txt
pause 