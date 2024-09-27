# API Documentación
## Overview

El proyecto ha sido creado utilizando el patron CQRS respetando los principios solid y configurado para poder ser desplegado en una funcion lambda con url activada para exponer los endpoints directamente, se han utilizado diversos patrones comunmente usados en la industria y se ha elegido una arquitectura clean. 

## Contenido
1. [¿Como Utilizar?](#getting-started)
2. [Endpoints](#endpoints)
   - [Request 1: `GET /autos/obtener?id`](#get-users)
   - [Request 2: `POST /autos/crear`](#post-users)
   - [Request 3: `PUT /autos/actualizar`](#put-users-id)
   - [Request 4: `DELETE /autos/eliminar?id`](#delete-users-id)

3. [Manejo de Errores](#error-handling)
4. [Plantilla de Despliegue AWS](#error-handling)
5. [Informacion de Contacto](#contact-information)

## ¿Como Utilizar?

La api esta desplegada en AWS con las rutas especificadas en los archivos postman y 2 environment, si estas ejecutando en tu propia pc puedes utilizar el ambiente local
1. Environment Local [here](#).
2. Environment Lambda [rate limits](#rate-limits).
(#endpoints).

## Endpoints

Los endpoints estan documentados en el archivo postman adjunto

## Manejo de Errores

Se ha usado el patron de respuesta generica para manejar las respuestas del 

## Plantilla de Despliegue AWS
 adjunto





