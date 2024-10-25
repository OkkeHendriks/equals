module LibA
    type TypeWithPrivateConstructor = private {
            Value: int
        }

    let makeValueOfTypeWithPrivateConstructor v = {Value = v}