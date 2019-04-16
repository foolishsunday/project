$(document).ready(function(){

	$("#btnGet").click(function(){

		$.get("demo.asp",function(data,status){
			var txt = "Data: " + data;
			// txt += "\n";
			txt += " Status: " + status; 
			alert(txt);
		});

	});

	$("#btnPost").click(function(){

		$.post("demo_post.asp",{
			name:"Lee",
			city:"shenzhen"
		},
		function(data,status){
			alert(data+","+status);
		});

	});		

});