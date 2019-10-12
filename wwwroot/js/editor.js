/*Logica para pagina editor*/

//referencias de elementos de editor
var titulo = document.getElementById("titulo_text");
var cuerpo_textarea = document.getElementById("cuerpo_articulo");
var stringhtml = "";
var vista_p = "";

function ajustarDimensionesCuerpoEditor(){
    setTimeout(function(){
        cuerpo_textarea.style.height = this.scrollHeight + "px";
    },0);
}
cuerpo_textarea.addEventListener('keydown',ajustarDimensionesCuerpoEditor);

function actualizarVistaPrevia(){
    try{
        
        stringhtml = 
        "<h2>" + titulo.value + "</h2> " + cuerpo_textarea.value;
        
        vista_p = document.getElementById("vista_previa");
        vista_p.innerHTML = stringhtml;
    
    }catch(Exception){
        console.error();
    }
}

//editor grafico
//variables de estado de etiquetas del editor grafico
var textarea_cuerpo = document.getElementById("cuerpo_articulo");

//referencias botones del editor grafico
var boton_em = $('#boton_em');
var boton_p = $('#boton_p');
var boton_strong = $('#boton_strong');
var boton_u = $('#boton_u');
var boton_img = $('#boton_img');
var boton_a = $('#boton_a');

//eventos on clic de los botones del editor

var textoSeleccionado = "";
var textoSeleccionadoConEtiquetas = "";
var textoAntesDeSeleccion = "";
var textoDespuesDeSeleccion = "";
boton_p.on("click",function(){
    if(textarea_cuerpo.selectionStart === textarea_cuerpo.selectionEnd){
        textoDespuesDeSeleccion = "";
        textoAntesDeSeleccion = "";
        
        for(i=0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);

        }
        for(i=textarea_cuerpo.selectionStart; i<textarea_cuerpo.value.length;i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + "<p></p>" + textoDespuesDeSeleccion;
        
        textarea_cuerpo.selectionStart = textoAntesDeSeleccion.length + 3;
        textarea_cuerpo.selectionEnd = textoAntesDeSeleccion.length + 3;
        textarea_cuerpo.focus();
        
    }else{
        for(var i=textarea_cuerpo.selectionStart;i<textarea_cuerpo.selectionEnd;i++){
            textoSeleccionado += textarea_cuerpo.value.charAt(i);
        }
        textoSeleccionadoConEtiquetas = "<p>" + textoSeleccionado + "</p>";
        console.log(textoSeleccionado);
        console.log(textoSeleccionadoConEtiquetas);
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";
        
        for(i = 0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        for(i = textarea_cuerpo.selectionEnd; i<textarea_cuerpo.value.length; i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + textoSeleccionadoConEtiquetas + textoDespuesDeSeleccion;
        textoSeleccionado = "";
        textoSeleccionadoConEtiquetas = "";
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";
    }
});
boton_strong.on("click",function(){
    if(textarea_cuerpo.selectionStart === textarea_cuerpo.selectionEnd){
        textoDespuesDeSeleccion = "";
        textoAntesDeSeleccion = "";

        for(i=0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);

        }
        for(i=textarea_cuerpo.selectionStart; i<textarea_cuerpo.value.length;i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + "<strong></strong>" + textoDespuesDeSeleccion;

        textarea_cuerpo.selectionStart = textoAntesDeSeleccion.length + 8;
        textarea_cuerpo.selectionEnd = textoAntesDeSeleccion.length + 8;
        textarea_cuerpo.focus();

    }else{
        for(var i=textarea_cuerpo.selectionStart;i<textarea_cuerpo.selectionEnd;i++){
            textoSeleccionado += textarea_cuerpo.value.charAt(i);
        }
        textoSeleccionadoConEtiquetas = "<strong>" + textoSeleccionado + "</strong>";
        console.log(textoSeleccionado);
        console.log(textoSeleccionadoConEtiquetas);
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";

        for(i = 0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        for(i = textarea_cuerpo.selectionEnd; i<textarea_cuerpo.value.length; i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + textoSeleccionadoConEtiquetas + textoDespuesDeSeleccion;
        textoSeleccionado = "";
        textoSeleccionadoConEtiquetas = "";
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";
    }
});
boton_em.on("click", function () {
    if(textarea_cuerpo.selectionStart === textarea_cuerpo.selectionEnd){
        textoDespuesDeSeleccion = "";
        textoAntesDeSeleccion = "";

        for(i=0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);

        }
        for(i=textarea_cuerpo.selectionStart; i<textarea_cuerpo.value.length;i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + "<em></em>" + textoDespuesDeSeleccion;

        textarea_cuerpo.selectionStart = textoAntesDeSeleccion.length + 4;
        textarea_cuerpo.selectionEnd = textoAntesDeSeleccion.length + 4;
        textarea_cuerpo.focus();

    }else{
        for(var i=textarea_cuerpo.selectionStart;i<textarea_cuerpo.selectionEnd;i++){
            textoSeleccionado += textarea_cuerpo.value.charAt(i);
        }
        textoSeleccionadoConEtiquetas = "<em>" + textoSeleccionado + "</em>";
        console.log(textoSeleccionado);
        console.log(textoSeleccionadoConEtiquetas);
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";

        for(i = 0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        for(i = textarea_cuerpo.selectionEnd; i<textarea_cuerpo.value.length; i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + textoSeleccionadoConEtiquetas + textoDespuesDeSeleccion;
        textoSeleccionado = "";
        textoSeleccionadoConEtiquetas = "";
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";
    }
});
boton_u.on("click", function () {
    if(textarea_cuerpo.selectionStart === textarea_cuerpo.selectionEnd){
        textoDespuesDeSeleccion = "";
        textoAntesDeSeleccion = "";

        for(i=0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);

        }
        for(i=textarea_cuerpo.selectionStart; i<textarea_cuerpo.value.length;i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + "<u></u>" + textoDespuesDeSeleccion;

        textarea_cuerpo.selectionStart = textoAntesDeSeleccion.length + 3;
        textarea_cuerpo.selectionEnd = textoAntesDeSeleccion.length + 3;
        textarea_cuerpo.focus();

    }else{
        for(var i=textarea_cuerpo.selectionStart;i<textarea_cuerpo.selectionEnd;i++){
            textoSeleccionado += textarea_cuerpo.value.charAt(i);
        }
        textoSeleccionadoConEtiquetas = "<u>" + textoSeleccionado + "</u>";
        console.log(textoSeleccionado);
        console.log(textoSeleccionadoConEtiquetas);
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";

        for(i = 0;i<textarea_cuerpo.selectionStart;i++){
            textoAntesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        for(i = textarea_cuerpo.selectionEnd; i<textarea_cuerpo.value.length; i++){
            textoDespuesDeSeleccion += textarea_cuerpo.value.charAt(i);
        }
        textarea_cuerpo.value = textoAntesDeSeleccion + textoSeleccionadoConEtiquetas + textoDespuesDeSeleccion;
        textoSeleccionado = "";
        textoSeleccionadoConEtiquetas = "";
        textoAntesDeSeleccion = "";
        textoDespuesDeSeleccion = "";
    }
})
boton_img.on("click", function(){
   //pendiente 
});
boton_a.on("click", function () {
    //pendiente
});