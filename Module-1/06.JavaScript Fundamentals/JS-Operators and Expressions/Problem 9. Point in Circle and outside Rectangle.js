//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3)
// //and out of the rectangle R(top=1, left=-1, width=6, height=2).
var arrX = [1,3,0,4,2,4,2.5,3.5,-100];
var arrY = [4,2,1,1,0,0,1.5,1.5,-100];

for(var i = 0; i < arrX.length; i++){
    var isThePointInCircle = (arrX[i] - 1) * (arrX[i] - 1) + (arrY[i] - 1) * (arrY[i] - 1) <= 3 * 3;
    var isThePointInRectangle = (arrY[i] <= 1 && arrY[i] >= -1) && (arrX[i] <= 5 && arrX[i] > -1);

    if(isThePointInCircle && !isThePointInRectangle){
        console.log('P('+arrX[i]+', '+arrY[i] +') -> Yes!');
    }
    else{
        console.log('P('+arrX[i]+', '+arrY[i] +') -> No!');
    }

}