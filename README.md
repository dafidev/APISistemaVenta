0 ASP.NET Core web API
 
1 crear de la base de datos
 
2 tools --> nuget --> console PM -->default project --> SistemaVenta.Model-->

Scaffold-DbContext "Server=01P0423\SQLEXPRESS01; DataBase=DBSALE; User ID=sa; Password=OrbitaIng06; TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer
 
3 en dbcontext movido quitar la cadena de configuracion de la funcion OnConfiguring --> 

Para ponerla en el appsettings.json de sisetemaventa.api
 
4 se crea clase dependency en SV.IOC Y se añade al program la configuration del settings
 
5 Creamos clases dto en el proyecto DTO para obtener los datos de base de datos y cogerlos de ahi ya que directamente es una mala practica
 
6 con automapper en utility convertimos de model a dto y viceversa. creamos AutoMapperProfile
 
7 crear interfaces y clases en Dal/repo y bll/services
 
8 creamos controllers en sistemaventa.API y añadimos cors y new Policy.
 
9 comprobar en cmd la version de angular --> ng version. No esta instalado seguir https://angular.dev/installation
 
10 install angular --> npm install -g @angular/cli
 
11 seleccionar ruta--> cmd --> ng new AppSistemaVenta --> n --> css --> y --> y
 
12 seleccionar ruta --> code .
 
13 instalar paquetes en vs code --> ctrl+ñ --> ng add @angular/material@miversion -->y --> y --> se puede ver la version en vscode en packages
 
14 npm install sweetalert2@11.6.16 --> para trabajar conalertas personalizadas
 
15 npm install moment@2.29.4 --save --> para trabajar con los formatos de fecha
 
16 npm i @angular/material-moment-adapter@miversion --> para trabajar con los formatos de fecha en material
 
17 npm install chart.js@3.9.1 --> para trabajar con graficos
 
18 npm i xlsx@0.18.5 --> para reportes en excel
 