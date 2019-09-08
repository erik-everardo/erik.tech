//variables de estado de etiquetas del editor grafico
var parrafoAbierto = false;
var negritasAbierto = false;
var subyaradoAbierto = false;
var italicaAbierto = false;

/*Logica para pagina editor*/
function calculaAlturaCuerpo(){
    var barra = document.getElementById("nav-tab");
    var input_titulo = document.getElementById("titulo_text");
    var barraNavegacion = document.getElementById("barra-navegacion-dash");
    var textareacuerpo  = document.getElementById("cuerpo_articulo");

    var pxArribaCuerpo = barra.offsetHeight + input_titulo.offsetHeight + barraNavegacion.offsetHeight;
    return window.innerHeight - pxArribaCuerpo;
}
function ajustarDimensionesCuerpoEditor(){
    var cuerpo = document.getElementById("cuerpo_articulo");
    cuerpo.style.height = calculaAlturaCuerpo() + "px";
}
window.addEventListener("resize", function(){
    var cuerpo = document.getElementById("cuerpo_articulo");
    cuerpo.style.height = calculaAlturaCuerpo() + "px";
});

function actualizarVistaPrevia(){

    try{
        var titulo = document.getElementById("titulo_text");
        var cuerpo_textarea = document.getElementById("cuerpo_articulo");
        var stringhtml = 
        "<h2>" + titulo.value + "</h2> " + cuerpo_textarea.value;
        
        var vista_p = document.getElementById("vista_previa");
        vista_p.innerHTML = stringhtml;
    
    }catch(Exception){
        console.error();
        
    }
}