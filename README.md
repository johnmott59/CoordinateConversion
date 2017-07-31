# CoordinateConversion
Program to demonstrate conversion from one coordinate system to another

This program is based on the Code Project located at

https://www.codeproject.com/Articles/36868/Quaternion-Mathematics-and-D-Library-with-C-and-G

This program was designed to demonstrate Quaternions but what I needed was something up and running that would let me 
work with a plane that could be rotated. It saved me a few days work to use an existing program to do development on the coordinate rotation issue.

This program demonstrates the solution to the problem of rotation between two different 3D coordinate systems.

When you run this program there is a red face on the cube. You can rotate the cube, and thus the red face. The button 'Apply Transform' will restore the red face of the cube to the front.

The button 'Reverse Transform' will restore the cube, and thus the red face, to its previous position.

The paper here 

http://homepages.engineering.auckland.ac.nz/~pkel015/SolidMechanicsBooks/Part_III/Chapter_1_Vectors_Tensors/Vectors_Tensors_05_Coordinate_Transformation_Vectors.pdf

Describes the math used. You create a 3x3 matrix whose elements are the dot products of the two sets of coordinate axis, and this transform can then be used to rotate the cube back and forth.
