![posgresql]( https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)![net](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)![aws](https://img.shields.io/badge/Amazon_AWS-FF9900?style=for-the-badge&logo=amazonaws&logoColor=white)

# API Documentación

## Overview

El proyecto ha sido creado utilizando el patron CQRS respetando los principios solid y configurado para poder ser desplegado en una funcion lambda con url activada para exponer los endpoints directamente, se han utilizado diversos patrones comunmente usados en la industria y se ha elegido una arquitectura clean, ademas se ha utilizado el micro ORM dapper para la base de datos. 

## Contenido
1. [¿Como Utilizar?](#como-utilizar)
2. [Endpoints](#endpoints)
   - [Request 1: `GET /autos/obtener?id`](#get-users)
   - [Request 2: `POST /autos/crear`](#post-users)
   - [Request 3: `PUT /autos/actualizar`](#put-users-id)
   - [Request 4: `DELETE /autos/eliminar?id`](#delete-users-id)

3. [Manejo de Errores](#manejo-de-errores)
4. [Plantilla de Despliegue AWS](#plantilla-de-despliegue-aws)
5. [UML](#uml)
6. [Arquitectura](#arquitectura)
7. [Contacto](#contacto)

## ¿Como Utilizar?

La api esta desplegada en AWS con las rutas especificadas en los archivos postman y 2 environment, si estas ejecutando en tu propia pc puedes utilizar el ambiente local
1. Environment Local [aqui](https://github.com/iorusoul/TestUPCH/tree/main/Documentacion/Postman).
2. Environment Lambda [aqui](https://github.com/iorusoul/TestUPCH/tree/main/Documentacion/Postman).

### Muy Importante
es necesario agregar el archivo appsettings.json y añadir la cadena de conexion para probar en local, este archivo debe crearse en la raiz del proyecto test.upch con el nombre appsettings.json ...
```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "PosgreSQLConnString": "Server=127.0.0.0;Port=5432;Database=upch_test_db;Username=root;Password=root"
  }
}
```

## Endpoints

Los endpoints estan documentados en el archivo postman adjunto

## Manejo de Errores

Se ha usado el patron de respuesta generica para manejar las respuestas del 

## Plantilla de Despliegue AWS
 [aqui](https://github.com/iorusoul/TestUPCH/tree/main/Documentacion/AWS%20script)

 ## UML 
 ![uml](https://github.com/iorusoul/TestUPCH/blob/main/Documentacion/test_upch_uml.jpg?raw=true)

 ## Arquitectura

 ![arquitectura](https://miro.medium.com/v2/resize:fit:678/1*dyEEkN3GHQeg7sA6v22EHw.png)

## Contacto
### Ing. Rusbel Oliver Ruelas Paredes
### Email : rusbelruelas@gmail.com




