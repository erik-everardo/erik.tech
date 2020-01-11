//Erik Everardo
//Galeria de imagenes
//funciones y eventos

var campoURLImagenExterna = document.getElementById("url_imagen_externa");
var vistaPreviaImagenCargaExterna = document.getElementById("vista_previa_imagen_carga_externa");
var campoNombreImagenExterna = document.getElementById("nombre_imagen_externa");

$('#url_imagen_externa').on('input',function(){
   vistaPreviaImagenCargaExterna.innerHTML = "<img width='100%' src='" + campoURLImagenExterna.value + "'></img>"
    campoNombreImagenExterna.value = campoURLImagenExterna.value.substr(campoURLImagenExterna.value.lastIndexOf("/") + 1);
});
function cargarImagenExterna(){
    $.post("/admin/CargarURLImagenes",{
        idUsuario:idUsuario,
        url:campoURLImagenExterna.value,
        nombre:campoNombreImagenExterna.value,
        externa:true,
        __RequestVerificationToken: tokenDeVerificacion
    },function(){
        solicitarImagenesGaleria();
    })
}
$('#btn_agregar_imagen_externa').on('click',function(){
    cargarImagenExterna();
});
function solicitarImagenesGaleria(){
    $.get("/admin/Imagenes",{idUsuario:idUsuario},function(respuesta){
        document.getElementById("lista_imagenes").innerHTML = respuesta;
    });
}

function definirAlturaListaDeImagenes() {
    document.getElementById("lista_imagenes").style.maxHeight = (window.innerHeight - rowBarra.offsetHeight - document.getElementById("header_galeria_imagenes").offsetHeight - 8) + "px";
}