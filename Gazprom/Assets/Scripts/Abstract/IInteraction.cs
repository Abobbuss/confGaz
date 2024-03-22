// Объекты взаимодействия в игре

public interface IInteraction
{
    public void Interact(); // Метод для взаимодействия с объектом
    public bool CanInteract(); // Метод для определения может ли игрок взаимодействовать с объектом
}
