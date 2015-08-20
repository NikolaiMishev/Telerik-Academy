///Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        throw  new Error('X and Y should be numbers.');
    }

    if (!(this instanceof Point)) {
        return new Point(x, y);
    }

    this.x = x;
    this.y = y;
}

Point.prototype.toString = function() {
    return 'P(' + this.x + ',' + this.y + ')';
};

function Line(startPoint, endPoint) {
    if (!(startPoint instanceof Point) || !(endPoint instanceof Point)) {
        throw new Error("sPoint and ePoint should be instances of Point");
    }

    if (!(this instanceof Line)) {
        return new Line(startPoint, endPoint);
    }

    this.startPoint = startPoint;
    this.endPoint = endPoint;
}

Line.prototype.getDistance = function() {
    var x = (this.startPoint.x - this.endPoint.x) * (this.startPoint.x - this.endPoint.x);
    var y = (this.startPoint.y - this.endPoint.y) * (this.startPoint.y - this.endPoint.y);

    return Math.sqrt(x + y);
};

Line.prototype.toString = function() {
    return 'L[' + this.startPoint.toString() + ',' + this.endPoint.toString() + ']';
};

function canFormTringle(a, b, c) {
    return a.getDistance() < b.getDistance() + c.getDistance() &&
        b.getDistance() < c.getDistance() + a.getDistance() &&
        c.getDistance() < a.getDistance() + b.getDistance();
}

var pointA = new Point(2, 3),
    pointB = new Point(5, 6),
    pointC = new Point(3, 8),
    line1 = new Line(pointA, pointB),
    line2 = new Line(pointB, pointC),
    line3 = new Line(pointC, pointA);


console.log('pointA = ' + pointA.toString());
console.log('pointB = ' + pointB.toString());
console.log('pointC = ' + pointC.toString());
console.log('lineA = ' + line1.toString());
console.log('lineB = ' + line2.toString());
console.log('lineC = ' + line3.toString());
console.log('Can form triangle from lineA, lineB and lineC? ' + canFormTringle(line1, line2, line3));