$(document).ready(function(){
	var jqTxt = $("<p></p>").text("这是添加的新元素");
	$("#btnAppend").click(function(){
		$("#panel1").append(jqTxt);

	});

	$("#btnBefore").click(function(){
		$("#panel1").before(jqTxt);
	});

	$("#btnAfter").click(function(){
		$("#panel1").after(jqTxt);
	});

	$("#btnRemove").click(function(){
		$("p").remove();
	});

	$("#btnEmpty").click(function(){
		$(".panel").empty();
	});

	$("#btnSelectRemove").click(function(){
		$("p").remove(".pstyle");
	});
});