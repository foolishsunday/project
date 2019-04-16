window.onload=function(){
	var box=document.getElementById("odiv");
	box.removeChild(removeWhiteNode(box).firstChild);
};
function removeWhiteNode(node){
	for(var i=0;i<node.childNodes.length;i++)
	{
		if(node.childNodes[i].nodeType==3 && /^\s+$/.test(node.childNodes[i].nodeValue))
			node.childNodes[i].parentNode.removeChild(node.childNodes[i]);
	}
	return node;
}