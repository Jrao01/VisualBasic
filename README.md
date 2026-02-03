# Guía de Ejecución: ServiEmpaq System

Sigue estos pasos en tu terminal (PowerShell o CMD) para ejecutar el proyecto desde cero.

## 1. Prerrequisitos

Asegúrate de estar en la carpeta correcta del proyecto.

```powershell
cd "c:\Users\Owner\OneDrive\Escritorio\visual basic\ServiEmpaqSystem"
```

## 2. Limpieza (Opcional)

Si quieres asegurarte de que es una compilación completamente limpia, elimina las carpetas de compilación anteriores.

```powershell
dotnet clean
```

## 3. Restaurar Dependencias

Este comando descarga las librerías necesarias (como SQLite) que se definen en el archivo `.vbproj`.

```powershell
dotnet restore
```

## 4. Compilar el Proyecto (Build)

Este paso convierte tu código Visual Basic en un ejecutable (`.exe` / `.dll`).

```powershell
dotnet build
```

## 5. Ejecutar (Run)

Este comando inicia la aplicación.

```powershell
dotnet run
```

---

## Tips Adicionales

### Verificación de Errores

Si el comando `dotnet run` falla, verifica el estado del último build:

```powershell
dotnet build --no-incremental
```

### Ejecutar directamente el archivo generado

También puedes abrir el ejecutable directamente desde el explorador de archivos en la ruta:
`bin\Debug\net10.0-windows\ServiEmpaqSystem.exe`

-- actualmente el .exe no esta ejecutandose bien, se cierra automaticamente, checkear eso
