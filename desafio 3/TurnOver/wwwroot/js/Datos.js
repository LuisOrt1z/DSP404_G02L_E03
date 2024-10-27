CargarSesiones();
var Sesion = {
    Nombre: "",
    Disponibles: 5,
    Precio: 5
};

var ListaSesiones = [];

var Actualizar = document.getElementById("btnActualizar");
Actualizar.addEventListener('click', (e) => {
    let id = document.getElementById("ID_Concierto").value;

    GuardarSesiones(id);

});

function GuardarSesiones(ID) {
    //General
    let NGeneral= "General";
    let CGeneral = document.getElementById("CantidadGeneral").value;
    let PGeneral = document.getElementById("PrecioGeneral").value;
    ListaSesiones.push({ Nombre: NGeneral, Disponibles: CGeneral, Precio: PGeneral });
    //Plateado
    let NPlateado = "Plateado";
    let CPlateado = document.getElementById("CantidadPlateado").value;
    let PPlateado = document.getElementById("PrecioPlateado").value;
    ListaSesiones.push({ Nombre: NPlateado, Disponibles: CPlateado, Precio: PPlateado });
    //VIP
    let NVIP = "VIP";
    let CVIP = document.getElementById("CantidadVIP").value;
    let PVIP = document.getElementById("PrecioVIP").value;
    ListaSesiones.push({ Nombre: NVIP, Disponibles: CVIP, Precio: PVIP });

    let ID_Concierto = "SesionesID" + ID;
    localStorage.setItem(ID_Concierto, JSON.stringify(ListaSesiones));
}
function CargarSesiones() {
    let id = document.getElementById("ID_Concierto").value;
    let ID_Concierto = "SesionesID" + id;
    if (localStorage.getItem(ID_Concierto)) {
        var modal = JSON.parse(localStorage.getItem(ID_Concierto));
        //General
        document.getElementById("CantidadGeneral").value = modal[0].Disponibles;
        document.getElementById("PrecioGeneral").value = modal[0].Precio;
        //Plateado
        document.getElementById("CantidadPlateado").value = modal[1].Disponibles;
        document.getElementById("PrecioPlateado").value = modal[1].Precio;
        //VIP
        document.getElementById("CantidadVIP").value = modal[1].Disponibles;
        document.getElementById("PrecioVIP").value = modal[1].Precio;
    }
}



