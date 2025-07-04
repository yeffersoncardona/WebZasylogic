# ?? Proyecto Web de Atenci¨®n al Cliente

### ?? Descripci¨®n

Aplicaci¨®n web desarrollada en **ASP.NET Core MVC (.NET 8)** que permite:

- Registrar solicitudes de atenci¨®n al cliente mediante un formulario.
- Consultar un informe din¨¢mico de clientes atendidos con filtros por fecha, ordenamiento y actualizaci¨®n autom¨¢tica.

---

### ?? Tecnolog¨ªas utilizadas

- ASP.NET Core MVC (.NET 8)
- Bootstrap 5
- JavaScript (Fetch API)
- SQL Server
- HTML5/CSS3

---

### ?? Estructura del proyecto



/Controllers ©À©¤©¤ ClienteController.cs ©¸©¤©¤ ClienteApiController.cs

/Views/Cliente ©À©¤©¤ Index.cshtml ©¸©¤©¤ Informe.cshtml

/wwwroot ©¸©¤©¤ cliente.js

/Models ©¸©¤©¤ Cliente.cs

/BaseDatos ©À©¤©¤ AtencionCliente.bak # Respaldo de la base de datos ©¸©¤©¤ RestaurarBD.sql # Script para restaurar la base de datos

/appsettings.json /Program.cs /README.md


---


---

### ?? Configuraci¨®n

1. Clona el repositorio:
   ```bash
   git clone https://github.com/yeffersoncardona/WebZasylogic.git

2. Abre el proyecto en Visual Studio 2022 o superior.

3. Configura la cadena de conexiÃ³n en appsettings.json:

json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=AtencionClienteDB;Trusted_Connection=True;TrustServerCertificate=True"
}
4. Restaura la base de datos desde el respaldo:

Abre SQL Server Management Studio (SSMS).

5. Ejecuta el script BD/RestaurarBD.sql o usa el archivo .bak para restaurar manualmente.

Ejecuta el proyecto y accede a:

Formulario: https://localhost:7228/Cliente/Index

Informe: https://localhost:7228/Cliente/Informe

Instrucci¨®n SQL del informe

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
Validaci¨®n de duplicados por celular

Modal de Bootstrap para mensajes

Filtro por fecha en informe

Ordenamiento por columnas

Auto-refresh cada 30 segundos

Simulaci¨®n de datos en informe (sin conexiÃ³n real)

Respaldo y restauraci¨®n de base de datos incluidos

Autor
Yefferson Cardona Desarrollador .NET | Backend Specialist ?? yeffercardona@hotmail.com ?? https://github.com/yeffersoncardona