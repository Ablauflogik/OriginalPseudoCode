using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalPseudoCode
{

    //Maze is technically a graph = spanning tree

    //Define vertices and edges value

    //Mazer inherits from Graph:
    //    int rows
    //    int cols

    //Graph 
    //    list<Vertex> Vertices

    //Vertex:
    //    int Value
    //    list<Edge> Edges
    //    bool Visited

    //Edge:
    //    Edge int Weight
    //    Vetex Destination

    //**************************************************Algorithm********************************************************

    //rows * cols as vertices

    //create empty as vertices

    //create empty stack THEN push 1st vertex
    //    mark 1st vertex as visited

    //while(Stack isn't empty):
    //    drunk ass walk = true
    //    while (drunk ass walk)L
    //        if node on the top of stack has unvisited vertices:
    //             randomly pick a vertex and then make a connection, then push the vertex to the top of stack
    //             random vertex choice is marked as visited
    //        else drunk ass walk is false

    //    recurse backwards = true    
    //    while (recurse backwards):
    //        if top of the stack has unvisited adjacent vertices:
    //            recurse backwards = false
    //        else pop top vertex off stack

    //************************************************Finding all unvisited adjacent vertices of a certain vertex**********************

    //list<vertex> ret = empty list
    //v is the particular vertex

    ////for north
    //if (v.value > cols):
    //    ret.add (v.value - cols)
    ////for south
    //if (v.value < cols * (rows - 1)):
    //    ret.add (v.value + cols)
    ////for east
    //if (v.value % cols < cols - 1):
    //    ret.add(v.value + 1)
    ////for west
    //if (var.value % cols > 0):
    //    ret.add(v.value - 1)
    //remove all vertices in ret that are visited 
    //return ret

}
