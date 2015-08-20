// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5).
// {0,0} is the centre and 5 is the radius

var pointsX = [0,-5,-4,1.5,-4,100,0,0.2,0.9,2];
var pointsY = [1,0,5,-3,-3.5,-30,0,-0.8,-4.93,2.655];

for(var i = 0;i < pointsY.length; i++){
    var isInCircle = (pointsX[i] - 0) * (pointsX[i] - 0) + (pointsY[i] - 0) * (pointsY[i] - 0) <= 5 * 5;
    if(isInCircle){
        console.log('P('+pointsX[i]+', '+pointsY[i]+')' + ' is in circle? -> ' + true);
    }
    else{
        console.log('P('+pointsX[i]+', '+pointsY[i]+')' + ' is in circle? -> ' + false);
    }
}