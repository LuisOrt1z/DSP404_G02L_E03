
var Sesion = {
    Nombre: "",
    Disponibles: 5,
    Precio: 5
};

var ClaseSesion = {
    Sesion: "",
    Disponibles: 5,
    Cantidad: 1,
    Precio: 5,
    Total: 0
};
var ListaCSesiones = [];
function Comprar(id, nombre, fecha, ubicacion) {
    document.getElementById("IDconcierto").value = id;
    document.getElementById("NombreConcierto").value = nombre;
    document.getElementById("LugarConcierto").value = ubicacion;
    document.getElementById("FechaConcierto").value = fecha;
    CargarSesiones();
}

function CambiarSesion() {
    let TipoSesion = document.getElementById("tipoSesion").value;
    for (let i = 0; i < ListaCSesiones.length; i++) {
        if (ListaCSesiones[i].Nombre == TipoSesion) {
            ClaseSesion.Disponibles = Number(ListaCSesiones[i].Disponibles);
            ClaseSesion.Precio = Number(ListaCSesiones[i].Precio);
            break;
        }
        
    }
    let Label = document.getElementById("LabelsPrecio");
    let btn = document.getElementById("btnTicket");
    if (ClaseSesion.Disponibles == 0) {
        Label.innerHTML = `<h5 class="text-center" style="width:100%">No hay tickets disponibles . . .</h5><br />`;
        btn.innerHTML = ``;
    } else {
        Label.innerHTML = `
        <span class="input-group-text" style="width:35%" id="NombreSesion">${TipoSesion} ($${ClaseSesion.Precio.toFixed(2)})</span>
                            <div class="form-floating" style="width:65%">
                                <input type="number" class="form-control" id="CantidadSesion" name="CantidadSesion" step="1" onchange="NumBoletos()" value="1" required>
                                <label for="CantidadSesion">tickets disponibles <span id="Disponibles">${ClaseSesion.Disponibles}</span></label>
                            </div>

        `;
        btn.innerHTML = `<div class="row g-2" style="width: 100%">
                                <h5 class="text-center">Total: $<span id="Total">${ClaseSesion.Precio.toFixed(2)}</span> </h5><br />
                                <center><button type="submit" class="btn btn-success" id="btnActualizar" onclick="ActualizarTotal()" >Comprar tickets</button></center>
                                <input type="number" class="form-control" id="tTotal" name="tTotal" style="display: none" step="0.01" >
                            </div>`;
        NumBoletos();

    }
    
    
    

    
}

function NumBoletos() {
    let cantidad = document.getElementById("CantidadSesion").value;
    if (cantidad < 1) {
        document.getElementById("CantidadSesion").value = 1;
        cantidad = 1;
    }
    if (cantidad > ClaseSesion.Disponibles) {
        document.getElementById("CantidadSesion").value = ClaseSesion.Disponibles;
        cantidad = ClaseSesion.Disponibles;
    }

    ClaseSesion.Cantidad = cantidad;
    ClaseSesion.Total = ClaseSesion.Precio * ClaseSesion.Cantidad;

    document.getElementById("Total").innerHTML = ClaseSesion.Total.toFixed(2);

}

function CargarSesiones() {
    let id = document.getElementById("IDconcierto").value;
    let ID_Concierto = "SesionesID" + id;
    //
    var sesiones = document.getElementById("ContenedorSesiones");
    var Label = document.getElementById("LabelsPrecio");
    var btn = document.getElementById("btnTicket");
    if (localStorage.getItem(ID_Concierto)) {
        var modal = JSON.parse(localStorage.getItem(ID_Concierto));
        ListaCSesiones = modal;

        sesiones.innerHTML = `<select id="tipoSesion" class="form-control" onchange="CambiarSesion()" name="tipoSesion">
        <option value="General">Sesión General</option>
        <option value="Plateado">Sesión Plateado</option>
        <option value="VIP">Sesión VIP</option>
        </select>
        `;
        let precioInit = Number(ListaCSesiones[0].Precio);
        let cantInit = Number(ListaCSesiones[0].Disponibles);
        ClaseSesion.Disponibles = cantInit;
        ClaseSesion.Precio = precioInit;
        
        if (cantInit != 0) {
            Label.innerHTML = `
        <span class="input-group-text" style="width:35%" id="NombreSesion">General ($${precioInit.toFixed(2)})</span>
                            <div class="form-floating" style="width:65%">
                                <input type="number" class="form-control" id="CantidadSesion" name="CantidadSesion" step="1" onchange="NumBoletos()" value="1" required>
                                <label for="CantidadSesion">tickets disponibles <span id="Disponibles">${cantInit}</span></label>
                            </div>

        `;
            btn.innerHTML = `<div class="row g-2" style="width: 100%">
                                <h5 class="text-center">Total: $<span id="Total">${precioInit.toFixed(2)}</span> </h5><br />
                                <center><button type="submit" class="btn btn-success" id="btnActualizar" onclick="ActualizarTotal()">Comprar tickets</button></center>
                                <input type="number" class="form-control" id="tTotal" name="tTotal" style="display: none" step="0.01" >
                            </div>`;
            
        } else {
            Label.innerHTML = `<h5 class="text-center" style="width:100%">No hay tickets disponibles . . .</h5><br />`;
            btn.innerHTML = ``;
        }
        ClaseSesion.Total = precioInit * 1;
    } else {
        sesiones.innerHTML = `<h5 class="text-center">No hay sesiones disponibles . . .</h5><br />`;
        Label.innerHTML = "";
        btn.innerHTML = "";
    }
}
function ActualizarTotal() {
    document.getElementById("tTotal").value = parseFloat(ClaseSesion.Total);
    let id = document.getElementById("IDconcierto").value;
    let ID_Concierto = "SesionesID" + id;
    let TipoSesion = document.getElementById("tipoSesion").value;
    for (let i = 0; i < ListaCSesiones.length; i++) {
        if (ListaCSesiones[i].Nombre == TipoSesion) {
            ListaCSesiones[i].Disponibles -= ClaseSesion.Cantidad;
            break;
        }

    }
    localStorage.setItem(ID_Concierto, JSON.stringify(ListaCSesiones));
}


