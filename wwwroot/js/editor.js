
/*Logica para pagina editor*/
function calculaAlturaCuerpo(){
    var barra = document.getElementById("nav-tab");
    var input_titulo = document.getElementById("titulo_text");

    var pxArribaCuerpo = barra.offsetHeight + input_titulo.offsetHeight + 20;
    var altura = innerHeight - pxArribaCuerpo - 20;

    return altura;
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


/**************************************************************/

//borrar todos los values del articulo que se acaba de publicar
//Esto permite empezar otro articulo nuevo despues
