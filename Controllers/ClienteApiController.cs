using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WebZasylogic.Models;

namespace WebZasylogic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteApiController : ControllerBase
    {
        private readonly IConfiguration _config;

        public ClienteApiController(IConfiguration config)
        {
            _config = config;
        }
        [HttpPost("guardar")]
        public IActionResult GuardarCliente([FromBody] Cliente cliente)
        {
            using var conn = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            conn.Open();

            var cmdCheck = new SqlCommand("SELECT * FROM ATENCION_CLIENTE WHERE CELULAR = @Celular", conn);
            cmdCheck.Parameters.AddWithValue("@Celular", cliente.Celular);
            var reader = cmdCheck.ExecuteReader();

            if (reader.HasRows)
            {
                var datos = new Dictionary<string, string>();
                while (reader.Read())
                {
                    datos["Nombre"] = reader["NOMBRE"].ToString();
                    datos["Apellidos"] = reader["APELLIDOS"].ToString();
                    datos["Email"] = reader["EMAIL"].ToString();
                    datos["Sexo"] = reader["SEXO"].ToString();
                    datos["Motivo"] = reader["MOTIVO"].ToString();
                }
                return Ok(new { existe = true, datos });
            }

            reader.Close();

            var cmdInsert = new SqlCommand(@"
            INSERT INTO ATENCION_CLIENTE (NOMBRE, APELLIDOS, CELULAR, EMAIL, SEXO, MOTIVO, FECHA_ALTA)
            VALUES (@Nombre, @Apellidos, @Celular, @Email, @Sexo, @Motivo, GETDATE())", conn);

            cmdInsert.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmdInsert.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
            cmdInsert.Parameters.AddWithValue("@Celular", cliente.Celular);
            cmdInsert.Parameters.AddWithValue("@Email", cliente.Email);
            cmdInsert.Parameters.AddWithValue("@Sexo", cliente.Sexo);
            cmdInsert.Parameters.AddWithValue("@Motivo", cliente.Motivo);

            cmdInsert.ExecuteNonQuery();

            return Ok(new { existe = false });
        }
    }
}
