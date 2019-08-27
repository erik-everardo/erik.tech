$("#form_publicacion").submit(function(){

    var publicacion = $(this).serialize();
    $.post("/admin/publicar",publicacion);
    descartarArticuloEnEdicion();
    abrir_mis_articulos();
    return false;
});

//Solo pasar True o False
function trueOFalseABool(valor){
    return valor === "True";
}

$("#modalEditar").on('show.bs.modal',function(evento){
    //boton que desencadeno este modal
    var boton = $(evento.relatedTarget);
   //traer datos del boton editar que desencadeno este modal
   var id = boton.data("id");
   var encabezado = boton.data("encabezado");
   var titulo = boton.data("titulo");
   var cuerpo = boton.data("cuerpo");
   var linux = trueOFalseABool(boton.data("linux"));
   var windows = trueOFalseABool(boton.data("windows"));
   var macos = trueOFalseABool(boton.data("macos"));
   var android = trueOFalseABool(boton.data("android"));
   var desarrollo = trueOFalseABool(boton.data("desarrollo"));
   var gaming = trueOFalseABool(boton.data("gaming"));
   var hardware = trueOFalseABool(boton.data("hardware"));
   var otra = trueOFalseABool(boton.data("otra"));
   
   var modal = $(this);
   modal.find('#titulo_modal_editar').text('Editando ' + titulo);
   modal.find('#nombre_de_la_publicacion').val(titulo);
   modal.find('#encabezado_de_la_publicacion').val(encabezado);
   modal.find('#cuerpo_del_articulo').text(cuerpo);
   modal.find('#linux_check').prop('checked',linux);
   modal.find('#windows_check').prop('checked',windows);
   modal.find('#macos_check').prop('checked',macos);
   modal.find('#android_check').prop('checked',android);
   modal.find('#desarrollo_check').prop('checked',desarrollo);
   modal.find('#gaming_check').prop('checked',gaming);
   modal.find('#hardware_check').prop('checked',hardware);
   modal.find('#id_articulo').val(id);
   
   if(otra){
       modal.find('#categorias_titulo').text('Categorias (articulo actualmente sin categoria)');
   }
});


$("#form_editar").submit(function(){
    var paqueteAEnviar = $(this).serialize();
    $.post("/admin/editar",paqueteAEnviar,despuesDeEditar);
    
    
    return false;
});


function despuesDeEditar(respuesta){
    if(respuesta === "correcto"){
        $("#modalEditar").modal('hide');
        abrir_mis_articulos();
        var capa_notificaciones_tope = document.getElementById("capa_notificaciones");
        var notificacion = $('#notificacion_articulo_editado');
        capa_notificaciones_tope.style.visibility = "visible";
        
        notificacion.toast("show");
        
    }
}
