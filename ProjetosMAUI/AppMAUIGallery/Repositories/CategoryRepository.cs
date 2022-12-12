﻿using AppMAUIGallery.Models;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description = "Organização sequencial dos elementos.",
                        Page = typeof(StackLayoutPage)
                    },
                    new Component
                    {
                        Title = "Grid",
                        Description = "Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    },
                    new Component
                    {
                        Title = "AbsoluteLayout",
                        Description = "Liberdade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    },
                    new Component
                    {
                        Title = "FlexLayout",
                        Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.",
                        Page = typeof(FlexLayoutPage)
                    }
                }
            });
            categories.Add(new Category()
            {
                Name = "Componentes (Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "BoxView",
                        Description = "Um componente que cria um caixa para ser apresentada.",
                        Page = typeof(BoxViewPage)
                    },
                    new Component
                    {
                        Title = "Label",
                        Description = "Apresenta um texto na tela.",
                        Page = typeof(LabelPage)
                    },
                    new Component
                    {
                        Title = "Button",
                        Description = "Apresenta um botão na tela.",
                        Page = typeof(ButtonPage)
                    },
                    new Component
                    {
                        Title = "Image",
                        Description = "Apresenta uma imagem na tela.",
                        Page = typeof(ImagePage)
                    },
                    new Component
                    {
                        Title = "ImageButton",
                        Description = "Apresenta uma imagem com comportamento de botão.",
                        Page = typeof(ImageButtonPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component> {
                    new Component {
                        Title = "Frame",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(FramePage)
                    },
                    new Component {
                        Title = "Border",
                        Description = "Caixa que envolve outros elementos.",
                        Page = typeof(BorderPage)
                    },
                    new Component {
                        Title = "Shadow",
                        Description = "Adiciona uma sobra ao elemento.",
                        Page = typeof(ShadowPage)
                    }
                }
            });
            categories.Add(new Category
            {
                Name = "Formulários",
                Components = new List<Component> {
                    new Component {
                        Title = "Entry",
                        Description = "Cria uma caixa de entrada de texto.",
                        Page = typeof(EntryPage)
                    },
                    new Component {
                        Title = "Editor",
                        Description = "Cria uma caixa de entrada de texto de multiplas linhas.",
                        Page = typeof(EditorPage)
                    },
                    new Component {
                        Title = "Checkbox",
                        Description = "Cria uma caixa de marcação.",
                        Page = typeof(CheckBoxPage)
                    },
                    new Component {
                        Title = "RadioButton",
                        Description = "Cria uma caixa de marcação de escolha única.",
                        Page = typeof(RadioButtonPage)
                    },
                }
            });
            return categories;
        }
    }
}
