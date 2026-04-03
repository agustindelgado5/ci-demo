# Desarrollo práctico

## Creación del proyecto

Se creó una aplicación de consola en C# utilizando .NET:

dotnet new console -n ci-demo

## Creación del repositorio

Se inicializó un repositorio Git y se subió a GitHub para gestionar el código fuente:

git init
git add .
git commit -m "primer commit"

## Configuración del pipeline

Se creó un workflow en la ruta:

.github/workflows/ci.yml

El contenido del pipeline permite automatizar el proceso de integración continua.

## Pasos del pipeline

El pipeline realiza las siguientes acciones:

- Restauración de dependencias:
  Ejecuta `dotnet restore` para descargar las dependencias necesarias.

- Compilación del proyecto:
  Ejecuta `dotnet build` para verificar que el código compile correctamente.

- Ejecución de tests:
  Ejecuta `dotnet test` para validar el comportamiento del sistema.

## Ejecución automática

Cada vez que se realiza un push al repositorio, el pipeline se ejecuta automáticamente en GitHub Actions.

## Buenas prácticas aplicadas

- Uso de control de versiones con Git
- Automatización del proceso de build
- Inclusión de tests automáticos
- Uso de `.gitignore` para evitar versionar archivos innecesarios como `bin/` y `obj/`
