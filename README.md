# CI Demo con GitHub Actions

## Descripción

Este proyecto demuestra la implementación de un pipeline de Integración Continua (CI) utilizando GitHub Actions.

## Aplicación desarrollada

La aplicación consiste en un programa de consola simple desarrollado en C#. Actualmente muestra un mensaje por pantalla.

Su objetivo es servir como base para implementar un pipeline de Integración Continua, permitiendo validar automáticamente la compilación y ejecución de tests.

No busca resolver un problema complejo, sino demostrar el funcionamiento del pipeline CI.

## Funcionamiento

Cada vez que se realiza un push al repositorio, se ejecuta automáticamente un pipeline que realiza los siguientes pasos:

- Restore dependencies:
  Descarga las dependencias necesarias del proyecto.

- Build project:
  Compila el código fuente para verificar que no existan errores.

- Run tests:
  Ejecuta tests automáticos para validar el correcto funcionamiento del sistema.

## Tecnologías utilizadas

- C#
- .NET
- GitHub Actions

## Conclusión

La implementación de este pipeline permite automatizar la validación del código en cada cambio, mejorando la calidad del software y reduciendo errores en el proceso de desarrollo.
