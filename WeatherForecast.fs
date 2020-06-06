namespace AMS_UMC_LIVE

open System

type WeatherForecast =
    { Date: DateTime
      TemperatureC: int
      Summary: string }

    member this.TemperatureF =
        32 + (int (float this.TemperatureC / 0.5556))
