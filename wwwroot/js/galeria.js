//Erik Everardo
//Galeria de imagenes
//funciones y eventos

var campoURLImagenExterna = document.getElementById("url_imagen_externa");
var vistaPreviaImagenCargaExterna = document.getElementById("vista_previa_imagen_carga_externa");
var campoNombreImagenExterna = document.getElementById("nombre_imagen_externa");
var campoNombreImagenPropia  = document.getElementById("nombre_imagen_propia");

$('#url_imagen_externa').on('input',function(){
   vistaPreviaImagenCargaExterna.innerHTML = "<img width='100%' src='" + campoURLImagenExterna.value + "'></img>";
    campoNombreImagenExterna.value = campoURLImagenExterna.value.substr(campoURLImagenExterna.value.lastIndexOf("/") + 1);
});
function cargarImagenExterna(){
    $.post("/admin/CargarURLImagenes",{
        idUsuario:idUsuario,
        url:campoURLImagenExterna.value,
        nombre:campoNombreImagenExterna.value,
        externa:true,
        password:passwordActual,
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
window.addEventListener("resize",definirAlturaListaDeImagenes);
function definirAlturaListaDeImagenes() {
    if (window.innerWidth <= 768) {
        document.getElementById("lista_imagenes").style.maxHeight =
            (window.innerHeight - barraNavegacion.offsetHeight - document.getElementById("header_galeria_imagenes").offsetHeight -
                document.getElementById("cuadro_izq_galeria").offsetHeight - 8) + "px";
    } else {
        document.getElementById("lista_imagenes").style.maxHeight =
            (window.innerHeight - barraNavegacion.offsetHeight - document.getElementById("header_galeria_imagenes").offsetHeight - 8) + "px";
    }
    
}

//funcion para abrir vista previa de una imagen
function vistaPreviaImagen(url) {
    //pantalla de movil: ocultar cuadro de vista previa y abrir en nueva penstaña la imagen
    if (window.innerWidth<=768) {
        window.open(url,"_blank");
    } else {
        document.getElementById("vista_previa_imagen_galeria").innerHTML = 
            "<a href='" + url + "' target='_blank'><img class='w-100' src='" + url + "'></a>"
    }
}
var inputFile = document.querySelector("#archivo_imagen_propia");

$('#btn_subir_imagen_propia').on('click',function(){
    subirImagen(campoNombreImagenPropia.value);
});
$('#archivo_imagen_propia').on('input',function() {
   document.getElementById("vista_previa_imagen_subir").innerHTML =
       "<img src'#' id='imgElem' class='w-100'>";
   var reader = new FileReader();
   reader.onload = function (e) {
       $('#imgElem').attr('src', e.target.result); // Renderizamos la imagen
   };
    reader.readAsDataURL(inputFile.files[0]);
    campoNombreImagenPropia.value = inputFile.files[0].name;
});
function subirImagen(nombre){
    if(inputFile.files.length > 0){
        var formData = new FormData();
        formData.append("archivo",inputFile.files[0]);
        formData.append("accion","galeria");
        //spinner.style.display = "block";
        fetch("https://files-erik-tech.azurewebsites.net/guardar.php", {
            method: 'POST',
            body: formData
        }).then(function(r){
            return r.text();
        }).then(function(nombre_archivo){
            $.post("/admin/CargarURLImagenes",{
                idUsuario:idUsuario,
                url:"https://files-erik-tech.azurewebsites.net/img_galeria/" + nombre_archivo,
                nombre:nombre,
                externa:false,
                password:passwordActual,
                __RequestVerificationToken: tokenDeVerificacion
            },function(){
                
                solicitarImagenesGaleria();
            });
            //alert("imagen subida exitosamente");
            //document.getElementById("formulario_publicar_producto").reset();
        });
    }else{
        alert("Selecciona un archivo para cargar");
    }
}
function eliminarImagen(idImagen){
    if (confirm("¿Seguro que quieres eliminar la imagen?")) {
        $.post("/admin/Imagenes",{
            accion:"borrar",
            idImagen:idImagen,
            idUsuario:idUsuario,
            password:passwordActual,
            __RequestVerificationToken: tokenDeVerificacion
        },function(){
            solicitarImagenesGaleria();
            resetearVistaPreviaGaleria();
        });
    }
}
function resetearVistaPreviaGaleria(){
    document.getElementById("vista_previa_imagen_galeria").innerHTML =
        "<p class='card-text'>Haz clic en un elemento de la derecha</p>";
}

