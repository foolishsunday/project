$(document).ready(function(){

	$("#btnAdd").click(function(){
		$("#p2").addClass("pstyle");

	});

	$("#btnRemove").click(function(){
		$(".pstyle,#p2,.p3style,.panel").removeClass();

	});

	$("#btnToggle").click(function(){
		$("#panel1").toggleClass("panel");

	});

});