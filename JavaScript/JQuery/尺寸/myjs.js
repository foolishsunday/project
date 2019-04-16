$(document).ready(function(){

	$("#btnGet").click(function(){

		$("#panelId").text("width:"+$("#panelId").width() + "," + "height:" + $("#panelId").height());
	});

	$("#btnInner").click(function(){

		$("#panelId").text("width:"+$("#panelId").innerWidth() + "," + "height:" + $("#panelId").innerHeight());
	});

	$("#btnOuter").click(function(){

		$("#panelId").text("width:"+$("#panelId").outerWidth() + "," + "height:" + $("#panelId").outerHeight());
	});

	$("#btnWindow").click(function(){
		var txt = "doc width:"+$(document).width()+ "," + "height:" + $(document).height();
		txt += "\n";
		txt += "win width:"+$(window).width()+ "," + "height:" + $(window).height();
		$("#panelWindow").text(txt);

	});	

	$("#btnResize").click(function(){
		$("#panelWindow").width(100);
		$("#panelWindow").height(100);

	});	
});