function ValidateCheckBox(sender, args) {

    args.IsValid = document.getElementById("politicas").checked;

}

function ValidateForm() {

    var nombre = document.getElementById('nombre').value;
    var apellido = document.getElementById('apellido').value;
    var pass = document.getElementById('password').value;
    var confPass = document.getElementById('confPass').value;
    //var fechaNac = document.getElementById('fechaNac').value;
    var tel = document.getElementById('telefono');
    var emAlternativo = document.getElementById('email').value;
    var captcha = document.getElementById('confBot').value;

    if (nombre == "") {
        alert("Ingrese su nombre");
        return false;
    } else if (apellido == '') {
        alert("Ingrese su apellido");
        return false;
    } else if (pass == '') {
        alert("Ingrese una contraseña");
        return false;
    } else if (confPass == '') {
        alert("Ingrese la verificación de la contraseña");
        return false;
    } else if (fechaNac.value == '') {
        alert("Ingrese su fecha de nacimiento");
        return false;
    } else if (tel.value == '') {
        alert("Ingrese su teléfono");
        return false;
    } else if (emAlternativo == '') {
        alert("Ingrese un correo eletrónico alternativo");
        return false;
    } else if (captcha == '') {
        alert("Ingrese el captcha");
        return false;
    }

    var fechaMax = new Date();
    var fechaIngresada = new Date(fechaNac);


    if (fechaIngresada.getFullYear() < 1930 || fechaIngresada > fechaMax) {
        alert("La fecha ingresada debe estar entre el 01/01/1930 y el día actual");
    }

    if (tel.innerHTML.length != 10) {
        alert("El teléfono no tiene el formato correcto");
        return false;
    }

    if (/^\[a-z&A-Z]*$/.test(nombre)) {
        alert("El nombre debe contener sólo números");
        return false;
    }

    return true;
}