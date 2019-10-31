# posAngularDotNETCore
POS para la tienda ANTOJITOS en angular 8, .NET core 3.0 API REST y Entity F Core

======== ESTRUCTURA ========
La aplicacion consta de 4 proyectos:
1. AntojitoBusiness => Capa de negocio
2. AntojitoModel => Capa de datos, en el esta el mapping de EF code first
3. Antojitos => Vista, tiene el proyecto Angular y sus modulos
4. AntojitosApi => API REST con .NET Core 3.0 procesa el request de angular

======== PASOS ========
El proyecto AntojitosApi debe seleccionarse como proyecto de inicio en el IDE.
Desde Antojitos ir a la carpeta ClientApp para ejecutar "ng serve -o"  y tener la ejecucion de angular
Modificar conexion a la BD.

