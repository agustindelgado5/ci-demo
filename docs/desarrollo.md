## Desarrollo práctico

### Creación del proyecto
Se creó una aplicación de consola en C# utilizando .NET con el siguiente comando:

dotnet new console -n ci-demo

### Creación del repositorio
Se inicializó un repositorio Git y se subió a GitHub para gestionar el código fuente:

git init  
git add .  
git commit -m "primer commit"

### Configuración del pipeline
Se configuró un workflow de Integración Continua en la ruta:

.github/workflows/ci.yml

Este pipeline se ejecuta automáticamente ante cada push o pull request sobre la rama principal.

## Pipeline de Integración Continua

El pipeline está compuesto por los siguientes pasos:

### 1. Checkout del código
Se utiliza la acción `actions/checkout` para clonar el repositorio dentro del entorno de ejecución de GitHub Actions, permitiendo trabajar con el código fuente.

### 2. Configuración del entorno .NET
Se instala el SDK de .NET versión 9 mediante la acción `actions/setup-dotnet`, asegurando que el entorno tenga las herramientas necesarias para compilar y ejecutar el proyecto.

### 3. Restauración de dependencias
Se ejecuta el comando:

dotnet restore ./Tests/Tests.csproj

Este paso descarga todas las dependencias necesarias definidas en el proyecto de tests.

### 4. Compilación del proyecto
Se ejecuta:

dotnet build ./Tests/Tests.csproj --no-restore --configuration Release

Aquí se compila el proyecto en modo Release, verificando que el código no tenga errores de compilación.

### 5. Ejecución de tests
Se ejecuta:

dotnet test ./Tests/Tests.csproj --no-build --configuration Release

En este paso se ejecutan los tests unitarios desarrollados con xUnit, validando el correcto funcionamiento de la aplicación.

## Ejecución automática

El pipeline se ejecuta automáticamente cada vez que se realiza un push o pull request sobre la rama principal (main), permitiendo validar continuamente el estado del proyecto.

## Buenas prácticas aplicadas

- Uso de control de versiones con Git
- Automatización del proceso de integración
- Separación entre código de aplicación y tests
- Ejecución automática de pruebas unitarias
- Uso de archivo `.gitignore` para evitar versionar archivos innecesarios como `bin/` y `obj/`
