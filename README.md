# Summary

This repository demonstrates an issue with StrawberryShake 11.0.0-preview.136.

When a type implements several interfaces, and you use a fragment on one of these interfaces, the fields invoked in that fragment are not generated.

# How to reproduce

Given the following Schema:

```
type Query {
	vehicles: [Vehicle!]!
}

interface Vehicle {
	id: ID!
}

interface Car {
	nbSeats: Int!
}

type SportsCar implements Vehicle & Car {
	id: ID!
	nbSeats: Int!
}

type FamilyCar implements Vehicle & Car {
	id: ID!
	nbSeats: Int!
	securityRating: Int!
}

"The `ID` scalar type represents a unique identifier, often used to refetch an object or as key for a cache. The ID type appears in a JSON response as a String; however, it is not intended to be human-readable. When expected as an input type, any string (such as `\"4\"`) or integer (such as `4`) input value will be accepted as an ID."
scalar ID

"The `Int` scalar type represents non-fractional signed whole numeric values. Int can represent values between -(2^31) and 2^31 - 1."
scalar Int
```

Write the following Query:

```
query getVehicles {
  vehicles{
    ... on Car {
      nbSeats
    }
  }
}
```

# Results

![Missing Interface](https://raw.githubusercontent.com/gmiserez/StrawberryShake_MissingFieldsWhenSeveralInterfaces/master/images/InterfaceICarMissing.jpg)

![Missing Interface](https://raw.githubusercontent.com/gmiserez/StrawberryShake_MissingFieldsWhenSeveralInterfaces/master/images/MissingField.jpg)
