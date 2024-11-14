using System;
using System.Collections.Generic;

public class Solution
{
    private int time = 0;
    private List<IList<int>> result = new List<IList<int>>();
    private Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();

    public IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
    {
        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (var connection in connections)
        {
            graph[connection[0]].Add(connection[1]);
            graph[connection[1]].Add(connection[0]);
        }
        var visited = new int[n];
        var low = new int[n];
        DFS(-1, 0, visited, low);

        return result;
    }

    private void DFS(int parent, int current, int[] visited, int[] low)
    {
        visited[current] = low[current] = time++;

        foreach (var neighbor in graph[current])
        {
            if (neighbor == parent) continue; 

            if (visited[neighbor] == 0) 
            {
                DFS(current, neighbor, visited, low);
                low[current] = Math.Min(low[current], low[neighbor]);

                if (low[neighbor] > visited[current])
                {
                    result.Add(new List<int> { current, neighbor });
                }
            }
            else
            {
                low[current] = Math.Min(low[current], visited[neighbor]);
            }
        }
    }
}