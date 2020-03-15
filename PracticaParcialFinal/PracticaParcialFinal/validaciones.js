function ValidateForm() {
    var nombre = document.getElementById('TextBox1').value;
    var apellido = document.getElementById('TextBox2').value;
    var telefono = document.getElementById('TextBox3').value;

    if (nombre == '') {
        alert("Ingrese su nombre");
        return false;
    } else {
        if (apellido == '') {
            alert("Ingrese su apellido");
            return false;
        } else {
            if (telefono == '') {
                alert("Ingrese su telefono");
                return false;
            } else {
                return true;
            }
        }
    }
}