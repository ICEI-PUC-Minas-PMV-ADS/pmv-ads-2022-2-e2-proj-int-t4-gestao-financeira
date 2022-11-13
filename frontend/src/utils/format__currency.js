const maskCurrency = (value, locale, currency) => {
  return new Intl.NumberFormat(locale ? locale : "pt-BR", {
    style: "currency",
    currency: currency ? currency : "BRL",
  }).format(value);
};

export const oninputEvent = (event) => {
  const onlyDigits = event.target.value
    .split("")
    .filter((s) => /\d/.test(s))
    .join("")
    .padStart(3, "0");

  const digitsFloat = onlyDigits.slice(0, -2) + "." + onlyDigits.slice(-2);

  event.target.value = maskCurrency(digitsFloat);
};
