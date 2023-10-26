function MostrarActores(nombre, idSerie)
    {
        $.ajax(
            {
                type: 'POST',
                dataType: 'JSON',
                url:'/Home/VerDetalleActores', 
                data: {IdSerie : idSerie},
                success: 
                function (response)
                {
                    let string = ""
                    response.forEach(act => {
                        string += act.nombre + "<br>"
                    });
                    $("#contenido").html(string)
                    $("#nombre").html(nombre) 
                }
            }
        );
    }
    
    function MostrarTemporadas(nombre, idSerie) 
    {
        $.ajax(
        
            {
                type: 'POST',
                dataType: 'JSON',
                url:'/Home/VerDetalleTemporadas', 
                data: {IdSerie : idSerie}, 
                success: 
                function (response)
                {
                   let string = ""
                   response.forEach(temp => {
                        string += temp.numeroTemporada + "." + temp.tituloTemporada + "<br>"
                   });
                   $("#contenido").html(string)
                   $("#nombre").html(nombre)
                }
            }
        );
    }
    
    function MostrarInfoSerie(nombre, idSerie) 
    {
        $.ajax(
            {
                type: 'POST',
                dataType: 'JSON',
                url:'/Home/VerSerie', 
                data: {idSerie : idSerie}, 
                success: 
                function (response)
                {
                    console.log(response)
                   $("#nombre").html(nombre)
                   $("#contenido").html("La serie salio el año " + response.añoInicio + "<br>" + response.sinopsis)
                }
            }
        );
    }
