using DrinkMixer.Data.BO;

namespace DrinkMixer.Data.DAO
{
    /// <summary>
    /// Classe avec variables globales pour pouvoir travailler avec les données
    ///  => l'objectif serait d'avoir ces informations dans une DB ou fichier
    ///  ==> et injecter la classe qui gère les données via DI dans les services (MixerService)
    /// </summary>
    public static class Data
    {
        public static readonly ParameterBO Parameter = new() { Margin = 0.3m };

        private static readonly List<RecipeBO> RecipeList = InitData();
        public static List<RecipeBO> Recipes { get => RecipeList; }


        private static List<RecipeBO> InitData()
        {
            CurrencyBO Euro = new CurrencyBO
            {
                Id = 1,
                Name = "Euro",
                Tag = "€",
                RateToEuro = 1
            };

            CurrencyBO Dollars = new CurrencyBO
            {
                Id = 2,
                Name = "Dollars",
                Tag = "$",
                RateToEuro = 0.93m
            };

            IngredientBO Coffee = new IngredientBO
            {
                Id = 1,
                Name = "Café",
                PricePerDose = 1.0m,
                Currency = Euro
            };

            IngredientBO Sugar = new IngredientBO
            {
                Id = 2,
                Name = "Sucre",
                PricePerDose = 0.1m,
                Currency = Euro
            };

            IngredientBO Creme = new IngredientBO
            {
                Id = 3,
                Name = "Crème",
                PricePerDose = 0.5m,
                Currency = Euro
            };

            IngredientBO Tea = new IngredientBO
            {
                Id = 4,
                Name = "Thé",
                PricePerDose = 2.0m,
                Currency = Euro
            };

            IngredientBO Water = new IngredientBO
            {
                Id = 5,
                Name = "Eau",
                PricePerDose = 0.2m,
                Currency = Euro
            };

            IngredientBO Chocolate = new IngredientBO
            {
                Id = 6,
                Name = "Chocolat",
                PricePerDose = 1.0m,
                Currency = Euro
            };

            IngredientBO Milk = new IngredientBO
            {
                Id = 7,
                Name = "Lait",
                PricePerDose = 1.0m,
                Currency = Euro
            };

            return new List<RecipeBO> {
                        new RecipeBO {
                            Id = 1,
                            Name = "Expresso",
                            RecipeSteps = new List<RecipeStepBO> {
                                new RecipeStepBO {
                                    Id = 1,
                                    Order = 1,
                                    Dose = 1,
                                    Ingredient = Coffee
                                },
                                new RecipeStepBO {
                                    Id = 2,
                                    Order = 2,
                                    Dose = 1,
                                    Ingredient = Water
                                }
                            }
                        },
                        new RecipeBO {
                            Id = 2,
                            Name = "Allongé",
                            RecipeSteps = new List<RecipeStepBO> {
                                new RecipeStepBO {
                                    Id = 3,
                                    Order = 1,
                                    Dose = 1,
                                    Ingredient = Coffee
                                },
                                new RecipeStepBO {
                                    Id = 4,
                                    Order = 2,
                                    Dose = 2,
                                    Ingredient = Water
                                }
                            }
                        },
                        new RecipeBO {
                            Id = 3,
                            Name = "Capuccino",
                            RecipeSteps = new List<RecipeStepBO> {
                                new RecipeStepBO {
                                    Id = 5,
                                    Order = 1,
                                    Dose = 1,
                                    Ingredient = Coffee
                                },
                                new RecipeStepBO {
                                    Id = 6,
                                    Order = 2,
                                    Dose = 1,
                                    Ingredient = Chocolate
                                },
                                new RecipeStepBO {
                                    Id = 7,
                                    Order = 3,
                                    Dose = 1,
                                    Ingredient = Water
                                },
                                new RecipeStepBO {
                                    Id = 8,
                                    Order = 4,
                                    Dose = 1,
                                    Ingredient = Sugar
                                }
                            }
                        },
                        new RecipeBO {
                            Id = 4,
                            Name = "Chocolat",
                            RecipeSteps = new List<RecipeStepBO> {
                                new RecipeStepBO {
                                    Id = 9,
                                    Order = 1,
                                    Dose = 3,
                                    Ingredient = Chocolate
                                },
                                new RecipeStepBO {
                                    Id = 10,
                                    Order = 2,
                                    Dose = 2,
                                    Ingredient = Milk
                                },
                                new RecipeStepBO {
                                    Id = 11,
                                    Order = 3,
                                    Dose = 1,
                                    Ingredient = Water
                                },
                                new RecipeStepBO {
                                    Id = 12,
                                    Order = 4,
                                    Dose = 1,
                                    Ingredient = Sugar
                                }
                            }
                        },
                        new RecipeBO {
                            Id = 5,
                            Name = "The",
                            RecipeSteps = new List<RecipeStepBO> {
                                new RecipeStepBO {
                                    Id = 13,
                                    Order = 1,
                                    Dose = 1,
                                    Ingredient = Tea
                                },
                                new RecipeStepBO {
                                    Id = 14,
                                    Order = 2,
                                    Dose = 2,
                                    Ingredient = Water
                                }
                            }
                        },
                    };
        }
    }
}
