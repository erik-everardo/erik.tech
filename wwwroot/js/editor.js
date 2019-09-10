//variables de estado de etiquetas del editor grafico
var parrafoAbierto = false;
var negritasAbierto = false;
var subyaradoAbierto = false;
var italicaAbierto = false;


/*Logica para pagina editor*/
function ajustarDimensionesCuerpoEditor(){
    var text = this;
    setTimeout(function(){
        cuerpo_textarea.style.height = text.scrollHeight + "px";
    },0);
}
cuerpo_textarea.addEventListener('keydown',ajustarDimensionesCuerpoEditor);

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
