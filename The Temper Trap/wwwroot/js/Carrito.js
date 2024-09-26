let listaCarrito = false;
var productoscartas = [];
let platosNum = 0;
function Carrito(){
    if(listaCarrito == false){
        cartContainer.style.display = 'block';
        listaCarrito = true;
    }else{
        cartContainer.style.display = 'none';
        listaCarrito = false;
    }
}


const agregarcanastaboton = document.querySelectorAll(".botonC");
agregarcanastaboton.forEach(agregarcarta =>{
    agregarcarta.addEventListener("click",agregarcartaclick);  
});

const Cartashtml = document.querySelector(".encabezado");

function agregarcartaclick(Event){
    const boton = Event.target;
    const Bcarta = boton.closest(".menu-item");
    const Titulocarta = Bcarta.querySelector(".Titulo").textContent;
    const Preciocarta = Bcarta.querySelector(".precio").textContent;
    
    agregarcartas(Titulocarta,Preciocarta);
    
}

function agregarcartas(Titulocarta,Preciocarta){
    let existencias = productoscartas.find(objeto => objeto.Plato === Titulocarta);
    let precio = parseFloat(Preciocarta.replace('$', '')).toFixed(2);
    if(existencias){
        existencias.cantidad +=1;
    }else{
        productoscartas.push({ Plato: Titulocarta, Precio: precio, cantidad: 1 });
    }
    platosNum++;
    ActualizaCarrito();    
}

function ActualizaCarrito(){
    let cartItems = document.getElementById('cartItems');
    let contador = document.getElementById('contador');
    let total = document.getElementById('cartTotal');
    let monto = 0;
    contador.innerHTML = ""+platosNum;
    cartItems.innerHTML = "";
    let contenido = "";
    productoscartas.forEach((productos, index) => {
        monto = monto+(productos.Precio * productos.cantidad);
        contenido = `
    <p>${productos.Plato}  ($${productos.Precio} X ${productos.cantidad})</p>
    `;
    cartItems.innerHTML += contenido;
    
    });
    contenido = `
    ${monto.toFixed(2)}
    `;
    total.innerHTML = contenido;
}

function Vaciar(){
    productoscartas = [];
    platosNum = 0;
    ActualizaCarrito();
}

function CrearPago() {
    document.body.classList.add('modal-open');
    // Mostrar el modal y el fondo
    document.getElementById('modal-background').classList.remove('hidden');
    document.getElementById('payment-form-container').classList.remove('hidden');
    Carrito();

    let cartItems = document.getElementById('OrdenLista');
    let total = document.getElementById('TotalPago');
    let monto = 0;

    cartItems.innerHTML = "";
    let contenido = "";
    productoscartas.forEach((productos, index) => {
        monto = monto + (productos.Precio * productos.cantidad);
        contenido = `
    <p>${productos.Plato}  ($${productos.Precio} X ${productos.cantidad})</p>
    `;
        cartItems.innerHTML += contenido;

    });
    contenido = `
    ${monto.toFixed(2)}
    `;
    total.innerHTML = contenido;
}

function CerrarPago() {
    // Ocultar el modal y el fondo
    document.getElementById('modal-background').classList.add('hidden');
    document.getElementById('payment-form-container').classList.add('hidden');
    document.body.classList.remove('modal-open');
}

function confirmarPago(event) {
    event.preventDefault(); // Evitar el envío por defecto del formulario

    const address = document.getElementById('address').value;
    const cardNumber = document.getElementById('card-number').value;
    const cvv = document.getElementById('cvv').value;
    const vencimiento = document.getElementById('vencimiento').value;

    const productos = productoscartas.map(item => ({
        nombre: item.Plato,
        precio: item.Precio,
        cantidad: item.cantidad
    }));

    const total = parseFloat(document.getElementById('cartTotal').textContent);

    // Enviar datos al controlador
    fetch('/Home/ConfirmarPago', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({ address, cardNumber, cvv, vencimiento, productos, total }),
    })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                alert('Compra exitosa');
                Vaciar(); // Limpiar el carrito
                CerrarPago(); // Cerrar el modal
            } else {
                alert('Error en la compra');
            }
        })
        .catch((error) => {
            console.error('Error:', error);
        });
}
