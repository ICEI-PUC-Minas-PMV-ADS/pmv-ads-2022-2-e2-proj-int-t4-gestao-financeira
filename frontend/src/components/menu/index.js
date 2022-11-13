export const Menu = () => {
  let lineOne = document.createElement("div");
  let lineTwo = document.createElement("div");
  let lineThre = document.createElement("div");

  lineOne.className = "line__menu__hamburguer";
  lineTwo.className = "line__menu__hamburguer";
  lineThre.className = "line__menu__hamburguer";

  let containerMenu = document.createElement("div");
  containerMenu.className = "container__menu__hambuguer";

  containerMenu.appendChild(lineOne);
  containerMenu.appendChild(lineTwo);
  containerMenu.appendChild(lineThre);

  return containerMenu;
};
