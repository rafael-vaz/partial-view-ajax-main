document.getElementById("selOrdem").onchange = function()
{
var ordem = document.getElementById("selOrdem").value;
$.get("/Home/ListaProdutos?ordem="+ordem)/* chamada ajax */
.done(function(data){ /* conclusão da requisição: sucesso,ta é a informação retornada*/
$("#divLista").html(data);
})
.fail(function(){ /* faha na requisição */
alert("Falha ao concluir requisição.");
});
};