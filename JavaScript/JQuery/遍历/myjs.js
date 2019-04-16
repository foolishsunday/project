$(document).ready(function(){

	$("#btnFather").click(function(){
		$("#span1").parents("div").addClass("parent");
		$("#span1").parentsUntil("ul").addClass("blue");

	});

	$("#btnChildren").click(function(){
		$("#panelId").children("p.psyle").removeClass();
	});
	
	$("#btnFind").click(function(){
		$("#panelId").find(".spanstyle").removeClass();
		$("#panelId").find("#span1").removeClass();

	});
	
	$("#btnAll").click(function(){
		$("#panelId").find("*").fadeToggle("slow",null);
	});

});