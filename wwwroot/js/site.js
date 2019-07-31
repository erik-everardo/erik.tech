var _credencial
$("#login").submit(function(){
    
    var credencial = $(this).serialize();
    $.post("/admin/login",credencial,validar);
   _credencial = credencial;


    return false;
})

function redirigir(respuesta){
    document.write(respuesta)
}
function validar(ent){
    if(ent=="si"){
        

        //hacer un post a pagina home con nombre del usuario
        $.post("/admin/home",_credencial,redirigir);
    }else if (ent=="no"){
        //decir que esta mal el usuario
        alert("Verifique que su nombre y su contraseña estén correctos");
    }
}

$("#form_publicacion").submit(function(){

    var publicacion = $(this).serialize();
    $.post("/admin/publicar",publicacion);
    
    return false;
});




