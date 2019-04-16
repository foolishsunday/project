$(document).ready(function(){
	$("#btnFade").click(function(){
		$("#box").fadeTo("slow",0.5,null);
	});

	$("#btnSlide").click(function(){
		$(".panel").slideToggle();
	});
});
