using UnityEngine;

public static class Utils
{
    public static (float x, float y) GetEnemySpawnCoordinates(int spawnZoneNumber, Vector2 playerPosition, float cameraXShift, float cameraYShift)
    {
        float x;
        float y;

        switch (spawnZoneNumber)
        {
            case 1:
                {
                    x = Random.Range(playerPosition.x - cameraXShift, playerPosition.x - (cameraXShift / 2));
                    y = Random.Range(playerPosition.y + (cameraYShift / 2), playerPosition.y + cameraYShift);
                    break;
                }
            case 2:
                {
                    x = Random.Range(playerPosition.x - (cameraXShift / 2), playerPosition.x + (cameraXShift / 2));
                    y = Random.Range(playerPosition.y + (cameraYShift / 2), playerPosition.y + cameraYShift);
                    break;
                }
            case 3:
                {
                    x = Random.Range(playerPosition.x + (cameraXShift / 2), playerPosition.x + cameraXShift);
                    y = Random.Range(playerPosition.y + (cameraYShift / 2), playerPosition.y + cameraYShift);
                    break;
                }
            case 4:
                {
                    x = Random.Range(playerPosition.x - cameraXShift, playerPosition.x - (cameraXShift / 2));
                    y = Random.Range(playerPosition.y - (cameraYShift / 2), playerPosition.y + (cameraYShift / 2));
                    break;
                }
            case 5:
                {
                    x = Random.Range(playerPosition.x + (cameraXShift / 2), playerPosition.x + cameraXShift);
                    y = Random.Range(playerPosition.y - (cameraYShift / 2), playerPosition.y + (cameraYShift / 2));
                    break;
                }
            case 6:
                {
                    x = Random.Range(playerPosition.x - cameraXShift, playerPosition.x - (cameraXShift / 2));
                    y = Random.Range(playerPosition.y - cameraYShift, playerPosition.y - (cameraYShift / 2));
                    break;
                }
            case 7:
                {
                    x = Random.Range(playerPosition.x - (cameraXShift / 2), playerPosition.x + (cameraXShift / 2));
                    y = Random.Range(playerPosition.y - cameraYShift, playerPosition.y - (cameraYShift / 2));
                    break;
                }
            case 8:
                {
                    x = Random.Range(playerPosition.x + (cameraXShift / 2), playerPosition.x + cameraXShift);
                    y = Random.Range(playerPosition.y - cameraYShift, playerPosition.y - (cameraYShift / 2));
                    break;
                }
            default:
                {
                    x = Random.Range(playerPosition.x - cameraXShift, playerPosition.x - (cameraXShift / 2));
                    y = Random.Range(playerPosition.y + (cameraYShift / 2), playerPosition.y + cameraYShift);
                    break;
                }
        }

        return (x, y);
    }
}
