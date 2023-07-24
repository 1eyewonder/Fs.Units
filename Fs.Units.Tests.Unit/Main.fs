module Fs.Units.Tests

open Expecto

[<Tests>]
let tests =
    [
        SimpleUnitOfMeasureTests.lengthTests
        SimpleUnitOfMeasureTests.timeTests
        SimpleUnitOfMeasureTests.massTests
        SimpleUnitOfMeasureTests.temperatureTests
        SimpleUnitOfMeasureTests.angleTests
        SimpleUnitOfMeasureTests.dataStorageTests
        SimpleUnitOfMeasureTests.fuelEconomyTests
        SimpleUnitOfMeasureTests.frequencyTests
        SimpleUnitOfMeasureTests.illuminanceTests
        SimpleUnitOfMeasureTests.currentTests
        CompoundUnitOfMeasureTests.areaTests
        CompoundUnitOfMeasureTests.volumeTests
        CompoundUnitOfMeasureTests.inertiaTests
        CompoundUnitOfMeasureTests.speedTests
        CompoundUnitOfMeasureTests.forceTests
        CompoundUnitOfMeasureTests.dataTransferRateTests
        CompoundUnitOfMeasureTests.densityTests
        CompoundUnitOfMeasureTests.pressureTests
        CompoundUnitOfMeasureTests.powerTests
        CompoundUnitOfMeasureTests.energyTests
        CompoundUnitOfMeasureTests.electricChargeTests
        CompoundUnitOfMeasureTests.electromotiveForceTests
        CompoundUnitOfMeasureTests.inductanceTests   
    ]

[<EntryPoint>]
let main _ =   
    let config = FsCheckConfig.defaultConfig
    
    tests
    |> List.map (fun x -> x config)
    |> testList "Fs.Unit"
    |> runTestsWithCLIArgs [] [||]