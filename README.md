# ReportesC-
Pasos para crear reportes en c#
## paso 1
instalar el paquete NuGet de Microsoft.Reporting.WinForms.
Para esto iremos a Extensiones, luego a administrar extensiones y en el buscador pondremos Microsoft.Reporting.WinForms.
## paso 2
crearemos un elemento de conjunto de datos o Data Set
## paso 3
en el Data Set llamado DataSet1, iremos al explorador de servidores y lo conectaremos con nuestra base de datos SQL, luego pondremos el nombre de nuestra base de datos, que podremos encontrar al mmomento de abrir SQL Server Managment Studio y antes de conectarnos copiamos el apartado que dice **servidor**. 
## paso 4
Luego de copiar el servior lo pondremos en el del data set, usaremos la autentificacion de windows y confirmamos que vamos a confiar en el certificado del servidor. Finalmente comprobamos la conexion y aceptamos.
## paso 5
Ahora crearemos un elemento tipo informe y lo llamaremos ReportesC donde le pondremos una tabla y le daremos a alguna celda al icono de base de datos y seleccionaremos la opcion de añadir un origen, ahi pondremos el DataSet1 y le pondremos de nombre DataSetInforme
## paso 6 
luego de añadir el data set a nuestra tabla ya podremos poner los datos que queramos que salgan y en el las celdas que estan en el top pondremos el nombre que queramos que tenga la tabla. Si ya pusimos el maximo de datos que puede tener la tabla le daremos click derecho e insertaremos las celdas suficientes para poner los datos necesarios.
## paso 7 
Luego crearemos un form y le pondremos formReportes
## paso 8
en el formReportes añadiremos un objeto tipo ReportViewer y le daremos click derecho.
## paso 9
luego de darle click derecho nos dirigiremos a la esquina superior derecha y le daremos a la flechita
## paso 10
aqui elegiremos el ReportesC
## paso 11
leugo de esto tendremos que ejecutar la aplicacion y ahi veremos todos los datos de la base de datos en el reporte 
## paso 12 
para imprimirlo solo tendremos que darle al boton de gardar dentro del reportViewer y seleccionamos el lugar donde lo queramos guardar
### con esto ya tendremos el reporte hecho
