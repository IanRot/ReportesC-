# ReportesC-
Pasos para crear reportes en c#
## paso 1
instalar el paquete NuGet de Microsoft.Reporting.WinForms.
## paso 2
Para esto iremos a Extensiones, luego a administrar extensiones y en el buscador pondremos Microsoft.Reporting.WinForms.
## paso 3
crearemos un elemento de conjunto de datos o Data Set
![image](https://github.com/user-attachments/assets/6a07f3eb-0668-4a8d-99e6-05d178cd3699)

## paso 4
en el Data Set llamado DataSet1 

## paso 5
iremos al explorador de servidores y lo conectaremos con nuestra base de datos SQL
![image](https://github.com/user-attachments/assets/144378b1-2a6e-4381-8378-2985e37acca1)

## paso 6
luego pondremos el nombre de nuestra base de datos, que podremos encontrar al mmomento de abrir SQL Server Managment Studio y antes de conectarnos copiamos el apartado que dice **servidor**.
![image](https://github.com/user-attachments/assets/748d0430-3d20-488e-bcbf-02c27fe1f2a0)

## paso 7
Luego de copiar el servior lo pondremos en el del data set, usaremos la autentificacion de windows y confirmamos que vamos a confiar en el certificado del servidor.

![image](https://github.com/user-attachments/assets/145deb6e-1fc1-4950-a97f-e217f2875dae)

## paso 8
Finalmente comprobamos la conexion y aceptamos.
## paso 9
Ahora crearemos un elemento tipo informe y lo llamaremos ReportesC donde le pondremos una tabla y le daremos a alguna celda al icono de base de datos y seleccionaremos la opcion de añadir un origen, ahi pondremos el DataSet1 y le pondremos de nombre DataSetInforme
![image](https://github.com/user-attachments/assets/2bf82ab6-7bb5-4590-b674-314ddd68f77e)

## paso 10 
luego de añadir el data set a nuestra tabla ya podremos poner los datos que queramos que salgan y en el las celdas que estan en el top pondremos el nombre que queramos que tenga la tabla. Si ya pusimos el maximo de datos que puede tener la tabla le daremos click derecho e insertaremos las celdas suficientes para poner los datos necesarios.
![image](https://github.com/user-attachments/assets/39874418-6a39-4087-8c07-208cd00d7192)

## paso 11 
Luego crearemos un form y le pondremos formReportes
## paso 12
en el formReportes añadiremos un objeto tipo ReportViewer y le daremos click derecho.

## paso 13
luego de darle click derecho nos dirigiremos a la esquina superior derecha y le daremos a la flechita
## paso 14
aqui elegiremos el ReportesC
![image](https://github.com/user-attachments/assets/45e8d515-8a8e-4eb1-a874-d8ba93b13535)

## paso 15
leugo de esto tendremos que ejecutar la aplicacion y ahi veremos todos los datos de la base de datos en el reporte 
## paso 16 
para imprimirlo solo tendremos que darle al boton de gardar dentro del reportViewer y seleccionamos el lugar donde lo queramos guardar
### con esto ya tendremos el reporte hecho
