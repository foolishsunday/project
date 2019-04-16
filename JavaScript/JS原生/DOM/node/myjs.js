
/*
输出：
文本start-
元素null
文本-end
*/
// window.onload=function(){

// 	var odiv = document.getElementById('odiv');
// 	var box=odiv.childNodes;
// 	for(var i=0;i<box.length;i++)
// 	{
// 		if(box[i].nodeType==1)
// 			document.write('元素'+box[i].nodeValue+'</br>');
// 		else 
// 			document.write('文本'+box[i].nodeValue+'</br>');
// 	}




/*
输出：
start-
*/
// window.onload = function(){

// 	var odiv = document.getElementById('odiv');
// 	var last=odiv.lastChild;
// 	alert(last.previousSibling.previousSibling.nodeValue);

// };

/*
输出：
STRONG
*/
// window.onload = function(){

// 	var odiv = document.getElementById('odiv');
// 	var last=odiv.lastChild;
// 	alert(last.previousSibling.nodeName);

// };

/*
输出：
STRONG
*/
// window.onload = function(){

// 	var odiv = document.getElementById('odiv');
// 	var last=odiv.attributes;
// 	//alert(last.length);	//4
// 	var box=function(){
// 		var ch={
// 			n1:'0',
// 			n2:'0'
// 		};

// 		return{
// 			ch:ch
// 		};
// 	}();

// 	for(var i=0;i<last.length;i++)
// 	{

// 	}
// 	box.ch.n1=last[0].nodeValue;
// 	 alert(box.ch.n1);

// };



