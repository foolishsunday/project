$(document).ready(function(){

	$("#btnSiblingsr").click(function(){
		$("span").siblings().removeClass();
		// $("#span1").siblings().removeClass();
	});

	$("#btnNext").click(function(){
		$("#span1").next().removeClass();
	});
	
	$("#btnNextAll").click(function(){
		$("#span1").nextAll().removeClass();

	});
	
	$("#btnNextUntil").click(function(){
		$("#span1").nextUntil("#span3").removeClass();
	});

});