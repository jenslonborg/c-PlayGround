// Engine3D.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
#include "olcConsoleGameEngine.h"
#include <iostream>
#include <stack>
using namespace std;

class Engine3D : public olcConsoleGameEngine
{
public:
    Engine3D()
    {
        m_sAppName = L"3D Demo";
    }
public:
    bool OnUserCreate() override //Used to load static data like sound backgrounds etc.
    {
        return true;
    }
    bool OnUserUpdate(float fElapsedTime) override
    {
        return true;
    }
};

class Game2D : public olcConsoleGameEngine
{
public:
    Game2D()
    {
        m_sAppName = L"2D Game";
    }
public:
    bool OnUserCreate() override //Used to load static data like sound backgrounds etc.
    {
        myxPos = 10.0f;
        myyPos = 10.0f;
        return true;

    }
    bool OnUserUpdate(float fElapsedTime) override
    {
        for (int x = 0; x < m_nScreenWidth; x++)
        {
            Fill(0, 0, m_nScreenWidth, m_nScreenHeight, L' ', 0);
            DrawLine(0, 0, 10, 17, L'.', 7);
        }
        return true;
    }
private:
    float myxPos;
    float myyPos;
};

class Maze2D : public olcConsoleGameEngine
{
public:
    Maze2D()
    {
        m_sAppName = L"2D Maze";
    }
public:
    bool OnUserCreate() override //Used to load static data like sound backgrounds etc.
    {
        myMazeHeight = 20;
        myMazeWidth = 40;
        myPathWidth = 3;
        myPosition = make_pair(0, 0);
        myMaze = new int[myMazeHeight * myMazeWidth];
        //memset sets the 'myMazeWidth * myMazeHeight' first bytes in myMAze to 0
        memset(myMaze, 0x00, myMazeWidth * myMazeHeight * sizeof(int));
        myStack.push(make_pair(0, 0));
        myMaze[0] = CELL_VISITED;
        myVisitedCells = 1;
        //Build Maze
        srand(time(NULL));
        while (myVisitedCells < myMazeHeight * myMazeWidth)
        {
            auto offset = [&](int x, int y)
            {
                return (myStack.top().first + x + (myStack.top().second + y) * myMazeWidth);
            };
            //Step 1 Check if neighbour has been visited
            vector<int> neighboursNotVisited;
            //North Neighbour
            if (myStack.top().second > 0)
            {
                //Bitwise And operator &
                //01001000 &
                //10111000 =
                //--------
                //00001000
                if ((myMaze[offset(0, -1)] & CELL_VISITED) == 0)
                {
                    neighboursNotVisited.push_back(0);
                }
            }
            //East Neighbour
            if (myStack.top().first < myMazeWidth - 1)
            {
                if ((myMaze[offset(1, 0)] & CELL_VISITED) == 0)
                {
                    neighboursNotVisited.push_back(1);
                }
            }
            //South Neighbour
            if (myStack.top().second < myMazeHeight - 1)
            {
                if ((myMaze[offset(0, +1)] & CELL_VISITED) == 0)
                {
                    neighboursNotVisited.push_back(2);
                }
            }
            //West Neighbour
            if (myStack.top().first > 0)
            {
                if ((myMaze[offset(-1, 0)] & CELL_VISITED) == 0)
                {
                    neighboursNotVisited.push_back(3);
                }
            }
            if (!neighboursNotVisited.empty())
            {
                //Change the seed to generate different maze all the time

                int nextCellDir = neighboursNotVisited[rand() % neighboursNotVisited.size()]; // rand() % neighboursNotVisited.size() vill be rand int from size 0 to neighboursNotVisited.size()
                switch (nextCellDir)
                {
                case 0: // NORTH code to be executed if n = 2;
                    myMaze[offset(0, 0)] |= CELL_PATH_N; // a |= b  -> a = (a|b) | and or
                    myMaze[offset(0, -1)] |= CELL_PATH_S;
                    myStack.push(make_pair(myStack.top().first, myStack.top().second - 1));
                    break;
                case 1: // EAST code to be executed if n = 1;
                    myMaze[offset(0, 0)] |= CELL_PATH_E;
                    myMaze[offset(1, 0)] |= CELL_PATH_W;
                    myStack.push(make_pair(myStack.top().first + 1, myStack.top().second));
                    break;
                case 2: // SOUTH code to be executed if n = 2;
                    myMaze[offset(0, 0)] |= CELL_PATH_S;
                    myMaze[offset(0, 1)] |= CELL_PATH_N;
                    myStack.push(make_pair(myStack.top().first, myStack.top().second + 1));
                    break;
                case 3: // WEST code to be executed if n = 2;
                    myMaze[offset(0, 0)] |= CELL_PATH_W;
                    myMaze[offset(-1, 0)] |= CELL_PATH_E;
                    myStack.push(make_pair(myStack.top().first - 1, myStack.top().second));
                    break;
                }

                myMaze[offset(0, 0)] |= CELL_VISITED; // Tell the maze cell it has been visited
                myVisitedCells++;

            }
            else
            {
                myStack.pop();
            }
        }
        return true;
    }
    bool OnUserUpdate(float fElapsedTime) override
    {   
        Sleep(100);
        //Find new myNewPosition
        if (m_keys[VK_DOWN].bPressed || m_keys[VK_DOWN].bHeld)
        {
            if ((myMaze[myPosition.first + myPosition.second * myMazeWidth] & CELL_PATH_S) != 0)
                myPosition.second += 1;
        }
        if (m_keys[VK_UP].bPressed || m_keys[VK_UP].bHeld)
        {
            if ((myMaze[myPosition.first + myPosition.second * myMazeWidth] & CELL_PATH_N) != 0)
                myPosition.second -= 1;
        }
        if (m_keys[VK_RIGHT].bPressed || m_keys[VK_RIGHT].bHeld)
        {
            if ((myMaze[myPosition.first + myPosition.second * myMazeWidth] & CELL_PATH_E) != 0)
                myPosition.first += 1;
        }
        if (m_keys[VK_LEFT].bPressed || m_keys[VK_LEFT].bHeld)
        {
            if ((myMaze[myPosition.first + myPosition.second * myMazeWidth] & CELL_PATH_W) != 0)
                myPosition.first -= 1;
        }

        //Draw Maze
        Fill(0, 0, m_nScreenWidth, m_nScreenHeight, L' ');
        for (int x = 0; x < myMazeWidth; x++)
        {
            for (int y = 0; y < myMazeHeight; y++)
            {
                //Bitwise comparitor "&" returns 1 if and only if both inpus are 1
                //Fill center
                for (int m = 0; m < myPathWidth; m++)
                {
                    for (int n = 0; n < myPathWidth; n++)
                    {
                        if (myMaze[y * myMazeWidth + x] & CELL_VISITED)
                            Draw(x * (myPathWidth+1) + m, y * (myPathWidth+1) + n, PIXEL_SOLID, FG_WHITE);
                        else
                            Draw(x * (myPathWidth+1) + m, y * (myPathWidth+1) + n, PIXEL_SOLID, FG_RED);
                        //StartBox
                        Draw(m,n, PIXEL_SOLID, FG_BLUE);
                        //EndBox
                        Draw((myMazeWidth*(myPathWidth+1)- (myPathWidth + 1))+m, (myMazeHeight*(myPathWidth + 1)- (myPathWidth + 1))+n, PIXEL_SOLID, FG_BLUE);
                    }
                }
                //Fill edges
                for (int p = 0; p < myPathWidth; p++) 
                {
                    if(myMaze[y * myMazeWidth + x] & CELL_PATH_S)
                        Draw(x * (myPathWidth + 1) + p, y * (myPathWidth + 1) + myPathWidth, PIXEL_SOLID, FG_WHITE);
                    if (myMaze[y * myMazeWidth + x] & CELL_PATH_E)
                        Draw(x * (myPathWidth + 1) + myPathWidth, y * (myPathWidth + 1) + p, PIXEL_SOLID, FG_WHITE);
                }
            }
        }
        //Draw myPosition
        for (int m = 0; m < myPathWidth; m++)
        {
            for (int n = 0; n < myPathWidth; n++)
            {
                Draw(myPosition.first * (myPathWidth + 1) + m, myPosition.second * (myPathWidth + 1) + n, PIXEL_SOLID, FG_RED);
            }
        }
        return true;
    }
private:
    int myMazeHeight;
    int myMazeWidth;
    int* myMaze;

    enum {
        CELL_PATH_N = 0x01,
        CELL_PATH_E = 0x02,
        CELL_PATH_S = 0x04,
        CELL_PATH_W = 0x08,
        CELL_VISITED = 0x10,
    };
    int myVisitedCells;
    int myPathWidth;

    stack<pair<int, int>> myStack;
    pair<int, int> myPosition;
};

int main()
{
    Maze2D Maze;
    if (Maze.ConstructConsole(160, 100, 8, 8))
    {
        Maze.Start();
    }
    return 0;
}
