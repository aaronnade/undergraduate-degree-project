// JavaScript Document
//function navList() {
//    var $obj = $("#J_navlist");
//    $obj.find("h4").hover(function () {//hover() 方法规定当鼠标指针悬停在被选元素上时要运行的两个函数。方法触发 mouseenter 和 mouseleave 事件。
//        console.log("hover")
//        //注意: 如果只指定一个函数，则 mouseenter 和 mouseleave 都执行它。
//        $(this).addClass("hover");//addClass() 方法向被选元素添加一个或多个类。
//        //该方法不会移除已存在的 class 属性，仅仅添加一个或多个 class 属性。
//        //提示：如需添加多个类，请使用空格分隔类名。
//    }, function () {
//        $(this).removeClass("hover");//removeClass() 方法从被选元素移除一个或多个类。注释：如果没有规定参数，则该方法将从被选元素中删除所有类。
//    });
//    $obj.find("p").hover(function () {
//        if ($(this).hasClass("on")) { return; }//hasClass() 方法检查被选元素是否包含指定的 class。
//        $(this).addClass("hover");
//    }, function () {
//        if ($(this).hasClass("on")) { return; }
//        $(this).removeClass("hover");
//    });
//    $obj.find("h4").click(function () {
//        var $div = $(this).siblings(".list-item");//siblings() 获得匹配集合中每个元素的同胞，通过选择器进行筛选是可选的。
//        if ($(this).parent().hasClass("selected")) {
//            $div.slideUp(600);//通过使用滑动效果，隐藏被选元素，如果元素已显示出来的话。
//            $(this).parent().removeClass("selected");
//        }
//        if ($div.is(":hidden")) {//is() 方法用于查看选择的元素是否匹配选择器
//            $("#J_navlist li").find(".list-item").slideUp(600);
//            $("#J_navlist li").removeClass("selected");
//            $(this).parent().addClass("selected");
//            $div.slideDown(600);

//        } else {
//            $div.slideUp(600);
//        }
//    });
//}

var e1 = document.getElementsByTagName('h4')
e1.addEventListener("mouseover", function () {
    e1.classList.add('hover')
})
e1.addEventListener("mouseout", function () {
    e1.classList.remove('hover')
})

var e2 = document.getElementsByTagName('p')
e2.addEventListener("mouseover", function () {
    if (e2.classList.contains('on') == true) {
        return;
    }
    e2.className.add('hover')
})
e2.addEventListener("mouseout", function () {
    if (e2.classList.contains('on') == true) {
        return;
    }
    e2.classList.remove('hover')
})

function fun1() {
    console.log("已被点击")
    e3 = e2.nextSbiling
    if (e2.parentNode.classList.contains('selected') == true) {
        e3.style.visibility = "hidden"
        e2.parentNode.classList.remove('selected')
    }
}

//菜单选择右边页面
//function setUrl(url) {
//    $("#ipage").attr("src", url);
//    return false;
//}

//$(document).ready(function () {
//    $("#ipage").load(function () {
//        doReSize();
//    });
//    window.onresize = function () {
//        doReSize();
//    }
//});

//function doReSize() {
//    var panding = 20;
//    var clientHeight = $("#ipage").contents().find("body").height() + panding;
//    $("#ipage").height(clientHeight);
//    var divHeight = $("#location").height();
//    $("#ContentPlace").height(clientHeight + divHeight + 22);
//}

//window.onload = navList;