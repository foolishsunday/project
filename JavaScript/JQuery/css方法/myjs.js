$(document).ready(function(){

	$("#btnCss").click(function(){
		// $("#panelId").css("font-size","15px");

		$("#panelId").css({	//设置多个 CSS 属性
			"font-size":"55px",
			"background-color":"yellow"

		});
		
	});

});