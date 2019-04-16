$(document).ready(function(){
	var href;
	$("#btnText").click(function(){
		$("#panel1").text("设置了文本");
	});

	$("#btnHtml").click(function(){
		$("#panel1").html("<b>设置了Html</b>");
	});

	$("#btnVal").click(function(){
		$("#input").val("设置了表单");
	});

	$("#btnCall").click(function(){
		$("#panel1").text(function(i,origText){
			return "原来的字：" + origText + "，加上新的：Hello！";
		});
	});


	$("#btnAttr").click(function(){
		//$("#link").attr("href","https://www.baidu.com");
		$("#link").attr({
			"href":"https://www.baidu.com"
		});
	});
});
