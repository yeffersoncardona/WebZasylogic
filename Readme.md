# Proyecto Web de Atención al Cliente

###  Descripción

Aplicación web desarrollada en **ASP.NET Core MVC (.NET 8)** que permite:

- Registrar solicitudes de atención al cliente mediante un formulario.
- Consultar un informe dinámico de clientes atendidos con filtros por fecha, ordenamiento y actualización automática.

---

###  Tecnologías utilizadas

- ASP.NET Core MVC (.NET 8)
- Bootstrap 5
- JavaScript (Fetch API)
- SQL Server
- HTML5/CSS3

---

###  Estructura del proyecto



/Controllers  ClienteController.cs y ClienteApiController.cs

/Views/Cliente / Index.cshtml y Informe.cshtml

/wwwroot / cliente.js

/Models / Cliente.cs

/BD / AtencionCliente.bak # Respaldo de la base de datos o RestaurarBD.sql # Script para restaurar la base de datos

/appsettings.json /Program.cs /README.md


---


---

###  Configuración

1. Clona el repositorio:
   ```bash
   git clone https://github.com/yeffersoncardona/WebZasylogic.git

2. Abre el proyecto en Visual Studio 2022 o superior.

3. Configura la cadena de conexión en appsettings.json:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ATENCION_CLIENTE;Trusted_Connection=True;;TrustServerCertificate=True"
},
4. Restaura la base de datos desde el respaldo:

Abre SQL Server Management Studio (SSMS).

5. Ejecuta el script BD/RestaurarBD.sql o usa el archivo .bak para restaurar manualmente.

Ejecuta el proyecto y accede a:

Formulario: https://localhost:7228/Cliente/Index

Informe: https://localhost:7228/Cliente/Informe

Instrucción SQL del informe

-- Consulta para obtener el informe de clientes atendidos en julio de 2025
SELECT
    NOMBRE,
    APELLIDOS,
    CELULAR,
    EMAIL,
    SEXO,
    MOTIVO,
    FECHA_ALTA
FROM ATENCION_CLIENTE
WHERE FECHA_ALTA BETWEEN '2025-07-01' AND '2025-07-31'
ORDER BY FECHA_ALTA ASC;
Funcionalidades destacadas
Validación de duplicados por celular

Modal de Bootstrap para mensajes

Filtro por fecha en informe

Ordenamiento por columnas

Auto-refresh cada 30 segundos

Simulación de datos en informe (sin conexión real)

Respaldo y restauración de base de datos incluidos

Autor
Yefferson Cardona Desarrollador .NET | Backend Specialist ?? yeffercardona@hotmail.com ?? https://github.com/yeffersoncardona
