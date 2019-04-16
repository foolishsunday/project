$(document).ready(function(){

	$("#btnAjax").click(function(){
		$("#panelId").load("mytxt.txt",function(responseTxt,statusTxt,xhr){
			if(statusTxt == "success")
				alert("success");
			if(statusTxt == "error")
				alert("error: " + xhr.status +"\n" + xhr.statusTxt);
		});
	});



});