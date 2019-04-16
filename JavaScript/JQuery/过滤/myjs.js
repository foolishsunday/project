$(document).ready(function(){

	$("#btnFirst").click(function(){

		$("li span").first().removeClass();
	});

	$("#btnLast").click(function(){

		$("li span").last().removeClass();
	});

	$("#btnEq").click(function(){

		$(".spanstyle").eq("1").removeClass();
	});

	//下面的例子返回带有类名 "intro" 的所有 <p> 元素：
	//$("p").filter(".intro");

	$("#btnFilter").click(function(){

		$("span").filter(".spanstyle2").first().removeClass();
	});
});