function enviarFormulario() {
    const data = {
        nombre: document.getElementById("nombre").value,
        apellidos: document.getElementById("apellidos").value,
        celular: document.getElementById("celular").value,
        email: document.getElementById("email").value,
        sexo: document.querySelector("input[name='sexo']:checked").value,
        motivo: document.getElementById("motivo").value
    };

    fetch("/api/cliente/guardar", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify(data)
    })
        .then(res => res.json())
        .then(response => {
            if (response.existe) {
                alert("Cliente ya registrado:\n" + JSON.stringify(response.datos));
            } else {
                alert("Cliente registrado exitosamente.");
            }
        });
}
